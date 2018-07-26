from rest_framework.views import APIView
from .models import Player
from .serializer import PlayerSerializer
from rest_framework.response import Response
from django.http import HttpResponse, Http404
from rest_framework.renderers import JSONRenderer
import json


class PlayerView(APIView):

    def get(self, request):

        player_list = Player.objects.all()
        serializer = PlayerSerializer(player_list[0])
        json = JSONRenderer().render(serializer.data)
        return HttpResponse(json)

    def post(self, request):

        data = request.body.decode('utf-8')
        data = json.loads(data)

        username = data.get("username")
        password = data.get("password")

        try:
            player = Player.objects.get(username=username)
            if player.password == password:
                return Response(PlayerSerializer(player).data)
            else:
                player.password = ""
                return Response(PlayerSerializer(player).data)
        except Player.DoesNotExist:
            player = Player(username=username, password=password, global_rank=Player.objects.all().count() + 1)
            player.save()
            return Response(PlayerSerializer(player).data)
