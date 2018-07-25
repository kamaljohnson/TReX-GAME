from django.conf.urls import url
from .views import PlayerView
urlpatterns = [
    url(r'^show$', PlayerView.as_view(), name="lobby")
]