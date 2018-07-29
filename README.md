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

#### The project is still in development stage and any contributions to this project is always welcome 

#### 1. Clone this repo on your machine:

     git clone https://github.com/kamaljohnson/TReX-GAME.git


#### 2. **Optional step** Setup a virtualenv in your directory. 

If you haven't yet set up virtualenv on your machine, please install it via pip:


     sudo apt-get install python3-setuptools

     sudo easy_install3 pip    

     sudo pip3 install virtualenv

Then run:

     virtualenv -p python3 env && source env/bin/activate

#### 3. Install the build dependencies:

     pip3 install -r requirements.txt
