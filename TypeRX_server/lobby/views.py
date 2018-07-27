from rest_framework.views import APIView
from .models import Player
from .serializer import PlayerSerializer, LobbyFeedSerializer
from rest_framework.response import Response

import json


class UpdatePlayerView(APIView):

    def post(self, request):
        data = request.body.decode('utf-8')
        data = json.loads(data)

        username = data.get("username")
        player = Player.objects.get(username=username)

        player.status = data.get('status')
        player.save()
        return Response(PlayerSerializer(player).data)

class FeedView(APIView):

    def get(self, request):
        player_list = Player.objects.filter(status='L').values('username')
        serializer = LobbyFeedSerializer(player_list, many=True)
        parsing_data = {'players': serializer.data}
        return Response(parsing_data)


class PlayerView(APIView):

    def get(self, request):

        player_list = Player.objects.all()
        serializer = PlayerSerializer(player_list, many=True)
        return Response(serializer.data)

    def post(self, request):

        data = request.body.decode('utf-8')
        data = json.loads(data)

        username = data.get("username")
        password = data.get("password")

        # checks if a player with username is present in the db
        try:
            player = Player.objects.get(username=username)
            if player.password == password:
                player.status = 'L'
                player.save()
                return Response(PlayerSerializer(player).data)
            else:
                player.password = ""
                return Response(PlayerSerializer(player).data)
        except Player.DoesNotExist:
            player = Player(username=username, password=password, global_rank=Player.objects.all().count() + 1)
            player.status = 'L'
            player.save()
            return Response(PlayerSerializer(player).data)
