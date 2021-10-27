# Code structure


New like
-> LikeController -> articleService.Like -> messagingBoard.Publish(User_Liked, {user_id, })
-> TrackerMessageBoard -> likeService.Validate //saves or discards -> articleRepo.save -> messagingBoard.Publish(Article_Liked, {article_id })
-> CounterMessageBoard -> repository.AtomicIncrease(article_id) -> messagingBoard.Publish(New_Like_Count, {article_id, count})