from rest_framework.views import APIView
from .models import Player
from .serializer import PlayerSerializer
from rest_framework.response import Response
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
        serializer = PlayerSerializer(data=data)

        if serializer.is_valid():
            player = serializer.data
            check_player = Player.objects.get(username=player.username)

            if check_player:
                if (player.password == check_player.password):
                    print('found')
                    return Response(serializer.data)
                else:
                    print('invalid')
                    return Response(serializer.data)
            else:
                print('created')
                player = Player(username=player.username, password=player.password)
                player.save()
                return Response(serializer.data)
        print('here')
        return HttpResponse(Http404)
