from django.conf.urls import url
from channels.routing import URLRouter
from .consumers import ChatConsumer

URLRouter([
    # message/<thread_id>/<username>/
    url(r"^(?P<thread_id>\w+)/$)/(?P<username>\w+)/$", ChatConsumer),
])
