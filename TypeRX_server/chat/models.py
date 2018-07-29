from django.db import models
from lobby.models import Player


# class Thread(models.Model):
#     start_time = models.DateTimeField()
#     duration = models.DurationField()
#     # player_list


class ChatMessages(models.Model):
    # thread = models.ForeignKey(Thread, on_delete=models.CASCADE)
    username = models.ForeignKey(Player, on_delete=models.CASCADE)
    message = models.TextField()
