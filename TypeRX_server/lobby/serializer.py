from rest_framework import serializers
from .models import Player


class PlayerSerializer(serializers.ModelSerializer):

    class Meta:
        model = Player
        fields = ('username', 'password', 'global_rank', 'matches_won', 'type_speed', 'letters_typed', 'status', 'local_rank')


class LobbyFeedSerializer(serializers.ModelSerializer):

    class Meta:
        model = Player
        fields = ('username',)

    # def create(self, validated_data):
    #     """
    #     Create and return a new `Snippet` instance, given the validated data.
    #     """
    #     return Player.objects.create(**validated_data)

    # def create(self, validated_data):
    #     username = validated_data.('username')
    #     wechat_num = validated_data.pop('wechat_num')
    #     password = validated_data.pop('password')
    #
    #     user_obj = User(
    #         username=username,
    #         wechat_num=wechat_num,
    #     )
    #     user_obj.set_password(password)
    #     user_obj.save()
    #     group = getOrCreateGroupByName(USER_GROUP_CHOICES.User)
    #     user_obj.groups.add(group)
    #
    #     return validated_data
    # # Login fields
    # username = serializers.CharField(max_length=10)
    # password = serializers.CharField(max_length=10)
    #
    # # Profile fields
    # global_rank = serializers.IntegerField(required=False)
    # matches_won = serializers.IntegerField(required=False, default=0)
    # type_speed = serializers.IntegerField(required=False, default=0)
    # letters_typed = serializers.IntegerField(required=False, default=0)
    #
    # # Game fields
    # status = serializers.CharField(max_length=5)
    # local_rank = serializers.IntegerField(required=False, allow_null=True)
