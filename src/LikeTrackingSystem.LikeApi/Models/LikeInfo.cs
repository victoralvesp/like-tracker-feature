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
using LikeTrackingSystem.LikeApi.Converters;

namespace LikeTrackingSystem.LikeApi.Models
{ 
    /// <summary>
    /// Information about article likes and current user
    /// </summary>
    [DataContract]
    public partial class LikeInfo : IEquatable<LikeInfo>
    {
        /// <summary>
        /// Gets or Sets LikeCount
        /// </summary>
        [DataMember(Name="like_count", EmitDefaultValue=false)]
        public int LikeCount { get; set; }

        /// <summary>
        /// Whether the user liked the article
        /// </summary>
        /// <value>Whether the user liked the article</value>
        [DataMember(Name="user_liked_article", EmitDefaultValue=false)]
        public UserLikedArticle? UserLikedArticle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LikeInfo {\n");
            sb.Append("  LikeCount: ").Append(LikeCount).Append("\n");
            sb.Append("  UserLikedArticle: ").Append(UserLikedArticle).Append("\n");
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
            return obj.GetType() == GetType() && Equals((LikeInfo)obj);
        }

        /// <summary>
        /// Returns true if LikeInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of LikeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LikeInfo? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    LikeCount == other.LikeCount ||
                    
                    LikeCount.Equals(other.LikeCount)
                ) && 
                (
                    UserLikedArticle == other.UserLikedArticle ||
                    UserLikedArticle is not null &&
                    UserLikedArticle.Equals(other.UserLikedArticle)
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
                    
                    hashCode = hashCode * 59 + LikeCount.GetHashCode();
                    if (UserLikedArticle is not null)
                        hashCode = hashCode * 59 + UserLikedArticle.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
        #pragma warning disable 1591

        public static bool operator ==(LikeInfo left, LikeInfo right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(LikeInfo left, LikeInfo right)
        {
            return !Equals(left, right);
        }

        #pragma warning restore 1591
        #endregion Operators
    }
}
