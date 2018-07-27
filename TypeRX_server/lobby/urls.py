from django.conf.urls import url
from .views import PlayerView, FeedView, UpdatePlayerView
urlpatterns = [
    url(r'^login$', PlayerView.as_view(), name="lobby-login"),
    url(r'^feeds$', FeedView.as_view(), name="lobby-feed"),
    url(r'^update-player$', UpdatePlayerView.as_view(), name="lobby-update_player")
]