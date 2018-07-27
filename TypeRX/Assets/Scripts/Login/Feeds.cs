using System;
using System.Net;
using UnityEngine;
using System.Net;
using UnityEngine.UI;
using System.Collections.Generic;

public class Feeds : MonoBehaviour {

    Players players = new Players();

    public Text feeds_text;
    
    private void Update()
    {
        //feeds_text.text = "";
        //string response = new WebClient().DownloadString("http://127.0.0.1:8000/lobby/feeds");
        //print(response);
        //players = JsonUtility.FromJson<Players>(response);
        foreach(Player player in players.players)
        {
            //feeds_text.text = feeds_text.text + " " + player.username;
        }
    }
}

[Serializable]
public class Players
{
    public List<Player> players = new List<Player>();
}
