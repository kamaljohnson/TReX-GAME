# TReX-GAME   
## Type Race Xtreme
our online typing game supporting English and also local languages -Malayalam

- front end [Unity](https://www.unity3d.com)
- back end [Django](https://www.djangoproject.com)

### Game-Server Interaction 
#### The interaction of the game and the server is divided into three stages
- login 
- chat
- game

#### The following methods are used for the communications 
- [API](http://www.django-rest-framework.org/) calls for login from front-end
- websockets via [django-channels](https://channels.readthedocs.io/en/latest/) for chat and game communications
