using LikeTrackingSystem.Framework.Messaging;
using LikeTrackingSystem.LikeApi.Messaging;
using LikeTrackingSystem.LikeApi.Services;
using Moq;
using Xunit;

namespace LikeTrackingSystem.LikeApi.Tests
{
    public class ArticleServiceTests
    {
        [Fact]
        public void Publish_Message_When_User_Likes_An_Article()
        {
            //Given
            var articleService = Mock.Of<IArticleService>();
            var messagingBoard = Mock.Of<IMessagingBoard>();
            //When
            articleService.LikeArticle(articleId: "1", userId: "1");

            //Then
            Mock.Get(messagingBoard)
                .Verify(board => board.Publish(It.Is<IMessage>(message => IsLikeMessage(message))), Times.Once);

        }
        static bool IsLikeMessage(IMessage message) => message is LikeArticleMessage and { UserId: "1", ArticleId: "1" };
    }
}