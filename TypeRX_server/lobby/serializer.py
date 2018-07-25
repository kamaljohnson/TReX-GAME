from rest_framework import serializers
from .models import GAME_STATUS

class PlayerSerializer(serializers.Serializer):

    username = serializers.CharField()
    password = serializers.CharField()

    # Profile fields
    global_rank = serializers.IntegerField(unique=True)
    matches_won = serializers.IntegerField(default=0)
    type_speed = serializers.IntegerField(default=0)
    letters_typed = serializers.IntegerField(default=0)

    # Game fields
    status = serializers.CharField(choices=GAME_STATUS)
    local_rank = serializers.IntegerField(allow_null=True)