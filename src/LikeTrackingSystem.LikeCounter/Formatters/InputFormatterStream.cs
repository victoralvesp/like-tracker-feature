using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace LikeTrackingSystem.LikeCounter.Formatters
{
    /// <summary>
    /// /// Input Type Formatter to allow model binding to Streams 
    /// </summary>
    public class InputFormatterStream : InputFormatter
    {
        /// <summary>
        /// 
        /// </summary>
        public InputFormatterStream()
        {
            SupportedMediaTypes.Add("application/octet-stream");
            SupportedMediaTypes.Add("image/jpeg");
        }

        /// <inheritdoc/>
        protected override bool CanReadType(Type type)
        {
            if (type == typeof(Stream))
            {
                return true;
            }

            return false;
        }

        /// <inheritdoc/>
        public override Task<InputFormatterResult> ReadRequestBodyAsync(InputFormatterContext context)
        {
            return InputFormatterResult.SuccessAsync(context.HttpContext.Request.Body);
        }
    }
}
