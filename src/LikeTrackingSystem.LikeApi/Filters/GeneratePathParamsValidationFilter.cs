using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace LikeTrackingSystem.LikeApi.Filters
{
    /// <summary>
    /// Path Parameter Validation Rules Filter
    /// </summary>
    public class GeneratePathParamsValidationFilter : IOperationFilter
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="operation">Operation</param>
        /// <param name="context">OperationFilterContext</param>
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {
            var pars = context.ApiDescription.ParameterDescriptions;

            foreach (var par in pars)
            {
                var openapiParam = operation.Parameters.SingleOrDefault(p => p.Name == par.Name);

                var attributes = ((ControllerParameterDescriptor)par.ParameterDescriptor).ParameterInfo.CustomAttributes.ToList();

                if (attributes.Any() && openapiParam is not null)
                {
                    // Required - [Required]
                    var requiredAttr = attributes.FirstOrDefault(p => p.AttributeType == typeof(RequiredAttribute));
                    if (requiredAttr is not null)
                    {
                        openapiParam.Required = true;
                    }

                    // Regex Pattern [RegularExpression]
                    var regexAttr = attributes.FirstOrDefault(p => p.AttributeType == typeof(RegularExpressionAttribute));
                    if (regexAttr is not null and { ConstructorArguments.Count: > 0 } && regexAttr.ConstructorArguments[0].Value is string regex)
                    {
                        openapiParam.Schema.Pattern = regex;
                    }

                    // String Length [StringLength]
                    int? minLength = null, maxLength = null;
                    var stringLengthAttr = attributes.FirstOrDefault(p => p.AttributeType == typeof(StringLengthAttribute));
                    if (stringLengthAttr is not null and { NamedArguments.Count: > 0})
                    {
                        if (stringLengthAttr.NamedArguments.Count is 1 && stringLengthAttr.NamedArguments.Single(p => p.MemberName == "MinimumLength").TypedValue.Value is int length)
                        {
                            minLength = length;
                        }
                        
                        maxLength = (int)stringLengthAttr.ConstructorArguments[0].Value;
                    }

                    var minLengthAttr = attributes.FirstOrDefault(p => p.AttributeType == typeof(MinLengthAttribute));
                    if (minLengthAttr is not null)
                    {
                        minLength = (int)minLengthAttr.ConstructorArguments[0].Value;
                    }

                    var maxLengthAttr = attributes.FirstOrDefault(p => p.AttributeType == typeof(MaxLengthAttribute));
                    if (maxLengthAttr is not null)
                    {
                        maxLength = (int)maxLengthAttr.ConstructorArguments[0].Value;
                    }

                    if (minLength is not null)
                    {
                        openapiParam.Schema.MinLength = minLength;
                    }

                    if (maxLength is not null)
                    {
                        openapiParam.Schema.MaxLength = maxLength;
                    }

                    // Range [Range]
                    var rangeAttr = attributes.FirstOrDefault(p => p.AttributeType == typeof(RangeAttribute));
                    if (rangeAttr is not null)
                    {
                        var rangeMin = (int)rangeAttr.ConstructorArguments[0].Value;
                        var rangeMax = (int)rangeAttr.ConstructorArguments[1].Value;

                        openapiParam.Schema.MinLength = rangeMin;
                        openapiParam.Schema.MaxLength = rangeMax;
                    }
                }
            }
        }
    }
}

