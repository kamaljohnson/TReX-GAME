from django.conf.urls import url
from .views import PlayerView, FeedView
urlpatterns = [
    url(r'^login$', PlayerView.as_view(), name="lobby-login"),
    url(r'^feeds$', FeedView.as_view(), name="lobby-feed"),
]