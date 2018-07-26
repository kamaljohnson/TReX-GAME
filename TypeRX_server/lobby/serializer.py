from rest_framework import serializers

class PlayerSerializer(serializers.Serializer):

    username = serializers.CharField(max_length=10)
    password = serializers.CharField(max_length=10)

    # Profile fields
    global_rank = serializers.IntegerField()
    matches_won = serializers.IntegerField(default=0)
    type_speed = serializers.IntegerField(default=0)
    letters_typed = serializers.IntegerField(default=0)

    # Game fields
    status = serializers.CharField(max_length=5)
    local_rank = serializers.IntegerField(allow_null=True)