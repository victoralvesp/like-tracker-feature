# Code structure


## New like
1. API
-> LikeController -> articleService.Like -> messagingBoard.Publish(User_Liked, {article_id, user_id})
1. Tracker
-> TrackerMessageBoard -> trackService.Validate //saves or discards -> articleRepo.save -> messagingBoard.Publish(Article_Liked, {article_id, user_id })
1. Counter
-> CounterMessageBoard -> repository.AddEvent(article_id, event_hash, event_type) 
1. Counting cycle
   AllEvents -> count likes / unlikes -> messagingBoard.Publish(New_Like_Count, {article_id, count})

## Remove like
1. API
-> LikeController -> articleService.RemoveLike -> messagingBoard.Publish(User_Unliked, {article_id, user_id})

1. Tracker
-> TrackerMessageBoard -> likeService.Validate //saves or discards -> articleRepo.save -> messagingBoard.Publish(Article_Unliked, {article_id, user_id })

1. Counter
-> CounterMessageBoard -> repository.AtomicDecrease(article_id) -> messagingBoard.Publish(New_Like_Count, {article_id, count})