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
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using LikeTrackingSystem.LikeApi.Attributes;
using LikeTrackingSystem.LikeApi.Models;

namespace LikeTrackingSystem.LikeApi.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class LikeApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <param name="articleId"></param>
        /// <param name="xUserId"></param>
        /// <response code="200">Information found</response>
        /// <response code="400">The parameters you provided are invalid</response>
        /// <response code="404">The resource you were trying to reach is not found</response>
        [HttpGet]
        [Route("/articles/{article_id}/likes")]
        [ValidateModelState]
        [SwaggerOperation("ArticleLikesInfo")]
        [SwaggerResponse(statusCode: 200, type: typeof(LikeInfo), description: "Information found")]
        [SwaggerResponse(statusCode: 400, type: typeof(InlineResponse400), description: "The parameters you provided are invalid")]
        [SwaggerResponse(statusCode: 404, type: typeof(string), description: "The resource you were trying to reach is not found")]
        public virtual IActionResult ArticleLikesInfo([FromRoute (Name = "article_id")][Required]Guid articleId, [FromHeader][Required()]Guid xUserId)
        { 

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(LikeInfo));
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(InlineResponse400));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(string));
            string? exampleJson = null;
            exampleJson = "{\r\n  \"user_liked_article\" : \"\",\r\n  \"like_count\" : 0\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<LikeInfo>(exampleJson)
            : default(LikeInfo);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="articleId"></param>
        /// <param name="xUserId"></param>
        /// <response code="200">Success</response>
        /// <response code="400">The parameters you provided are invalid</response>
        /// <response code="404">The resource you were trying to reach is not found</response>
        [HttpPost]
        [Route("/articles/{article_id}/likes")]
        [ValidateModelState]
        [SwaggerOperation("LikeArticle")]
        [SwaggerResponse(statusCode: 200, type: typeof(LikeInfo), description: "Success")]
        [SwaggerResponse(statusCode: 400, type: typeof(InlineResponse400), description: "The parameters you provided are invalid")]
        [SwaggerResponse(statusCode: 404, type: typeof(string), description: "The resource you were trying to reach is not found")]
        public virtual IActionResult LikeArticle([FromRoute (Name = "article_id")][Required]Guid articleId, [FromHeader][Required()]Guid xUserId)
        { 

            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200, default(LikeInfo));
            //TODO: Uncomment the next line to return response 400 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(400, default(InlineResponse400));
            //TODO: Uncomment the next line to return response 404 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(404, default(string));
            string? exampleJson = null;
            exampleJson = "{\r\n  \"user_liked_article\" : \"\",\r\n  \"like_count\" : 0\r\n}";
            
            var example = exampleJson != null
            ? JsonConvert.DeserializeObject<LikeInfo>(exampleJson)
            : default(LikeInfo);
            //TODO: Change the data returned
            return new ObjectResult(example);
        }
    }
}
