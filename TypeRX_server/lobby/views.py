
from rest_framework.views import APIView
from .models import Player
from .serializer import PlayerSerializer
from django.http import HttpResponse, Http404
from rest_framework.renderers import JSONRenderer

class PlayerView(APIView):

    def get(self, request):

        player_list = Player.objects.all()
        serializer = PlayerSerializer(player_list[0])
        json = JSONRenderer().render(serializer.data)
        return HttpResponse(json)

    def post(self, request):

        data = request.body
        print(data)

        username = data.get('username')
        password = data.get('password')

        player = Player.objects.get(username = username)

        if(player):
            if(player.password == password):
                serializer = PlayerSerializer(player)
                return HttpResponse(serializer.data)
            else:
                player.password = ""
                serializer = PlayerSerializer(player)
                return HttpResponse(serializer.data)
        else:
            player = Player(username = username, password = password)
            player.save()
            return HttpResponse("")