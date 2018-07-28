import asyncio
import json
from django.contrib.auth import get_user_model
from channels.consumer import AsyncConsumer
from channels.db import database_sync_to_async

from .models import Thread, ChatMessages

class ChatConsumer(AsyncConsumer):
    async def websocket_connect(self, event):
        print("connected", event)
        await self.send({
            "type": "websocket.accept"
        })
        await self.send({
            "type": "websocket.send",
            "text": "Hello World",
        })

    async def websocket_receive(self, event):
        print("receive", event)

    async def websocket_dissconnect(self, event):
        print("disconnected", event)