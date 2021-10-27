using LikeTrackingSystem.Framework.Messaging;
using LikeTrackingSystem.LikeTracker.Messaging;
using LikeTrackingSystem.LikeTracker.Repository;
using LikeTrackingSystem.LikeTracker.Services;
using Moq;
using Xunit;

namespace LikeTrackingSystem.LikeTracker.Tests.Services
{
    public class TrackServiceTests
    {
        [Fact]
        public void Should_Register_That_User_Liked_An_Article_And_Publish_A_Message()
        {
            //Given
            var mockLikeRepository = new Mock<ILikeRepository>();
            var mockMessagingBoard = new Mock<IMessagingBoard>();
            var trackService = new TrackService(mockLikeRepository.Object, mockMessagingBoard.Object);

            //When
            trackService.UserLikedArticle("articleId", "userId");

            //Then
            mockLikeRepository.Verify(x => x.AddUserLike(It.Is<string>(s => s == "articleId"), It.Is<string>(s => s == "userId")), Times.Once);
            mockMessagingBoard.Verify(x => x.Publish(It.Is<ArticleLikedMessage>(s => s.ArticleId == "articleId" && s.UserId == "userId")), Times.Once);
        }

    }
}
