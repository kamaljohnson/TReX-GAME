from rest_framework import serializers
from .models import Player


class PlayerSerializer(serializers.ModelSerializer):

    class Meta:
        model = Player
        fields = ('username', 'password', 'global_rank', 'matches_won', 'type_speed', 'letters_typed', 'status', 'local_rank')

    username = serializers.CharField(max_length=10)
    password = serializers.CharField(max_length=10)

    # Profile fields
    global_rank = serializers.IntegerField(required=False)
    matches_won = serializers.IntegerField(required=False, default=0)
    type_speed = serializers.IntegerField(required=False, default=0)
    letters_typed = serializers.IntegerField(required=False, default=0)

    # Game fields
    status = serializers.CharField(max_length=5)
    local_rank = serializers.IntegerField(required=False, allow_null=True)
