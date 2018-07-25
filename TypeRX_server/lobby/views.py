from django.shortcuts import render

from rest_framework.views import APIView
from .models import Player
from .serializer import PlayerSerializer
from django.http import HttpResponse

class PlayerView(APIView):

    def get(self, request):

        player_list = Player.objects.all()
        serializer = PlayerSerializer(player_list, many=True)

        return HttpResponse(serializer.data)

    def post(self, request):
        pass
