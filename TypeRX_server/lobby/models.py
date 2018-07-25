from django.db import models


# Player
# Login
#   username
#   password
# Profile
#   global_rank
#   matches_won
#   type_speed
#   letters_typed
# Game
#   status (Playing, Lobby, Offline)
#   local_rank
# region Player Model
class Player(models.Model):
    GAME_STATUS = (
        ('P', 'Playing'),
        ('L', 'Lobby'),
        ('O', 'Offline'),
    )

    # Login fields
    username = models.CharField(max_length=10, primary_key=True)
    password = models.CharField(max_length=10)

    # Profile fields
    global_rank = models.IntegerField(unique=True)
    matches_won = models.IntegerField()
    type_speed = models.IntegerField()
    letters_typed = models.IntegerField()

    # Game fields
    status = models.CharField(max_length=10, choices=GAME_STATUS)
    local_rank = models.IntegerField()

# endregion
