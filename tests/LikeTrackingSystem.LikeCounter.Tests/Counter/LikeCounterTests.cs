using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using LikeTrackingSystem.LikeCounter.Counter;
using LikeTrackingSystem.LikeCounter.Repository;
using Moq;
using Xunit;

namespace LikeTrackingSystem.LikeCounter.Tests.Counter
{
    public class LikeCounterTests
    {
        [Fact]
        public void Should_Count_New_Events()
        {
            //Given that there are 10 article likes counted for id 19A41755
            var likeCounter = Mock.Of<ILikeCounter>();
            var likeCountRepository = LikeCountRepository(likeCount: 10);

            //When a new like event arrives for id 19A41755
            var articleEvent = LikeEvent(articleId: "19A41755");
            var articleLikes = likeCounter.CountLikes(articleEvent);

            //Then the total number of likes for id 19A41755 should be 11
            articleLikes.Should().Be(11);
        }

        [Fact]
        public void Should_Not_Count_Events_Twice()
        {
            //Given that there are 10 article likes counted for id 19A41755
            var likeCounter = Mock.Of<ILikeCounter>();
            var likeCountRepository = LikeCountRepository(likeCount: 10);

            //When a new like event arrives for id 19A41755
            var articleEvent = LikeEvent(articleId: "19A41755");
            _ = likeCounter.CountLikes(articleEvent);
            // And we try to count the same event again
            var articleLikes = likeCounter.CountLikes(articleEvent);

            //Then the total number of likes for id 19A41755 should be 11
            articleLikes.Should().Be(11);
        }

        private ILikeCountRepository LikeCountRepository(int likeCount)
        {
            var mock = new Mock<ILikeCountRepository>();

            mock.Setup(x => x.LikeCount(It.IsAny<string>()))
                .Returns(likeCount);

            return mock.Object;
        }

        private ILikeEventRepository LikeEventRepository(int newEvents, string? articleId = null)
        {
            var mock = new Mock<ILikeEventRepository>();
            var savedEvents = GenerateRandomEvents(newEvents, articleId).ToArray();
            mock.Setup(x => x.NewEvents())
                .Returns(savedEvents);
            return mock.Object;
        }

        private IEnumerable<ArticleLikeEvent> GenerateRandomEvents(int newEvents, string? articleId = null, DateTimeOffset? eventTime = null)
        {
            var random = new Random();
            for (int i = 0; i < newEvents; i++)
            {
                articleId ??= Guid.NewGuid().ToString();
                eventTime ??= DateTimeOffset.UtcNow;
                yield return LikeEvent(articleId, eventTime);
            }
        }

        private static ArticleLikeEvent LikeEvent(string? articleId = null, DateTimeOffset? eventTime = null)
        {
            articleId ??= Guid.NewGuid().ToString();
            eventTime ??= DateTimeOffset.UtcNow;
            return new(
                        ArticleId: articleId,
                        EventType: "Like",
                        EventHash: Md5Hash(articleId, Guid.NewGuid().ToString(), eventTime.Value.ToUnixTimeMilliseconds().ToString())
                    );
        }

        static string Md5Hash(params string[] inputs)
        {
            var md5 = System.Security.Cryptography.MD5.Create();
            var input = string.Join("", inputs);
            var inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            var hash = md5.ComputeHash(inputBytes);
            var sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
    }
}
