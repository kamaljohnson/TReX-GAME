from django.urls import path, re_path


from .views import MessageView, PlayerMessageView

app_name = 'chat'
urlpatterns = [
    path("", MessageView.as_view()),
    re_path(r"^(?P<username>[\w.@+-]+)", PlayerMessageView.as_view()),
]
