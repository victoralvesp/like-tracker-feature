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
    public partial class InlineResponse400 : IEquatable<InlineResponse400>
    {
        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<InlineResponse400Errors>? Errors { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string? Type { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=true)]
        public Object? Title { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or Sets TraceId
        /// </summary>
        [DataMember(Name="traceId", EmitDefaultValue=false)]
        public string? TraceId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse400 {\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TraceId: ").Append(TraceId).Append("\n");
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
            return obj.GetType() == GetType() && Equals((InlineResponse400)obj);
        }

        /// <summary>
        /// Returns true if InlineResponse400 instances are equal
        /// </summary>
        /// <param name="other">Instance of InlineResponse400 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse400? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Errors == other.Errors ||
                    Errors is not null &&
                    other.Errors is not null &&
                    Errors.SequenceEqual(other.Errors)
                ) && 
                (
                    Type == other.Type ||
                    Type is not null &&
                    Type.Equals(other.Type)
                ) && 
                (
                    Title == other.Title ||
                    Title is not null &&
                    Title.Equals(other.Title)
                ) && 
                (
                    Status == other.Status ||
                    
                    Status.Equals(other.Status)
                ) && 
                (
                    TraceId == other.TraceId ||
                    TraceId is not null &&
                    TraceId.Equals(other.TraceId)
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
                    if (Errors is not null)
                    hashCode = hashCode * 59 + Errors.GetHashCode();
                    if (Type is not null)
                    hashCode = hashCode * 59 + Type.GetHashCode();
                    if (Title is not null)
                    hashCode = hashCode * 59 + Title.GetHashCode();
                    
                    hashCode = hashCode * 59 + Status.GetHashCode();
                    if (TraceId is not null)
                    hashCode = hashCode * 59 + TraceId.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(InlineResponse400 left, InlineResponse400 right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(InlineResponse400 left, InlineResponse400 right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
