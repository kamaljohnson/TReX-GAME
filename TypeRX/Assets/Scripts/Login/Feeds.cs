using System;
using System.Net;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Feeds : MonoBehaviour {

    Players players = new Players();
    readonly float server_interaction_period = 0.5f;
    float timer;

    private void Update()
    {
        string response = new WebClient().DownloadString("http://192.168.43.10:8000/lobby/feeds");
        players = JsonUtility.FromJson<Players>(response);
        if (players != null)
        {
            foreach (Player player in players.players)
            {
                NotificationLogger.Load(player.username + " logged in");
            }
        }
    }
}

[Serializable]
public class Players
{
    public List<Player> players = new List<Player>();
}
