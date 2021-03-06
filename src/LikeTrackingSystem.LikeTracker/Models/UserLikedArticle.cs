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
    /// Whether the user liked the article
    /// </summary>
    [DataContract]
    public partial class UserLikedArticle : IEquatable<UserLikedArticle>
    {
        /// <summary>
        /// ID of the article
        /// </summary>
        /// <value>ID of the article</value>
        [DataMember(Name = "article_id", EmitDefaultValue = false)]
        public Guid ArticleId { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        /// <value>User ID</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Date when the user liked the article
        /// </summary>
        /// <value>Date when the user liked the article</value>
        [DataMember(Name = "like_date", EmitDefaultValue = false)]
        public DateTime LastUpdate { get; set; }

        /// <summary>
        /// Defines if the user has liked the article
        /// </summary>
        /// <value></value>
        [DataMember(Name = "has_liked", EmitDefaultValue = false)]
        public bool HasLiked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserLikedArticle {\n");
            sb.Append("  ArticleId: ").Append(ArticleId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  LikeDate: ").Append(LastUpdate).Append("\n");
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
            return obj.GetType() == GetType() && Equals((UserLikedArticle)obj);
        }

        /// <summary>
        /// Returns true if UserLikedArticle instances are equal
        /// </summary>
        /// <param name="other">Instance of UserLikedArticle to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserLikedArticle? other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    ArticleId == other.ArticleId ||
                    ArticleId.Equals(other.ArticleId)
                ) &&
                (
                    UserId == other.UserId ||
                    UserId.Equals(other.UserId)
                ) &&
                (
                    LastUpdate == other.LastUpdate ||
                    LastUpdate.Equals(other.LastUpdate)
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
                hashCode = hashCode * 59 + ArticleId.GetHashCode();
                hashCode = hashCode * 59 + UserId.GetHashCode();
                hashCode = hashCode * 59 + LastUpdate.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(UserLikedArticle left, UserLikedArticle right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(UserLikedArticle left, UserLikedArticle right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}
