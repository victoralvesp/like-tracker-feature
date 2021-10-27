using LikeTrackingSystem.LikeTracker.Repository;
using LikeTrackingSystem.LikeTracker.Services;
using Moq;
using Xunit;

namespace LikeTrackingSystem.LikeTracker.Tests.Services
{
    public class TrackServiceTests
    {
        [Fact]
        public void TestName()
        {
            //Given
            var mockLikeRepository = new Mock<ILikeRepository>();
            var trackService = Mock.Of<ITrackService>();

            //When
            trackService.UserLikedArticle("articleId", "userId");

            //Then
            mockLikeRepository.Verify(x => x.AddUserLike(It.Is<string>(s => s == "articleId"), It.Is<string>(s => s == "userId")), Times.AtMostOnce);
        }
    }
}
