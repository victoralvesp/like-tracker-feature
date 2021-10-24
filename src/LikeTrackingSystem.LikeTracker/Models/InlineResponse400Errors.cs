/*
 * Like API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 * 
 * Generated by: https://openapi-generator.tech
 */

using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using LikeTrackingSystem.LikeTracker.Converters;

namespace LikeTrackingSystem.LikeTracker.Models
{ 
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class InlineResponse400Errors : IEquatable<InlineResponse400Errors>
    {
        /// <summary>
        /// Gets or Sets Field
        /// </summary>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse400Errors {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object? obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((InlineResponse400Errors)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse400Errors instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse400Errors to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse400Errors? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Field == other.Field ||
                    Field is not null &&
                    Field.Equals(other.Field)
                ) && 
                (
                    Message == other.Message ||
                    Message is not null &&
                    Message.Equals(other.Message)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                    if (Field is not null)
                    hashCode = hashCode * 59 + Field.GetHashCode();
                    if (Message is not null)
                    hashCode = hashCode * 59 + Message.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponse400Errors left, InlineResponse400Errors right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse400Errors left, InlineResponse400Errors right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
