from django.urls import path, re_path


from .views import FrontEndInteractionView

app_name = 'chat'
urlpatterns = [
    re_path(r"^$", FrontEndInteractionView.as_view()),
]
