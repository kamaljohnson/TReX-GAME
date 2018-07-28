using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Net;


public class GameManager : MonoBehaviour {

    #region Game Status bools
    public static bool logged_in;
    public static bool playing;
    public static bool in_lobby;
    public static bool game_over;
    #endregion
    #region  UI GameObjects
    public GameObject LoginUI;
    public GameObject LobbyUI;
    public GameObject GameUI;
    public GameObject GameOverUI;
    #endregion

    public void Login()
    {


        AtLobby();
    }
    
    public void GameOver()
    {
        LocalPlayer.local_player.status = "P";
        new WebClient().UploadString("http://192.168.43.10:8000/lobby/update-player", JsonUtility.ToJson(LocalPlayer.local_player));

        logged_in = true;
        playing = false;
        in_lobby = false;
        game_over = true;

        LoginUI.SetActive(false);
        LobbyUI.SetActive(false);
        GameUI.SetActive(false);
        GameOverUI.SetActive(true);
    }

    public void StartGame()
    {
        LocalPlayer.local_player.status = "P";
        new WebClient().UploadString("http://192.168.43.10:8000/lobby/update-player", JsonUtility.ToJson(LocalPlayer.local_player));
       
        logged_in = true;
        playing = true;
        in_lobby = false;
        game_over = false;

        LoginUI.SetActive(false);
        LobbyUI.SetActive(false);
        GameUI.SetActive(true);
        GameOverUI.SetActive(false);
    }

    public void AtLobby()
    {
        LocalPlayer.local_player.status = "L";
        new WebClient().UploadString("http://192.168.43.10:8000/lobby/update-player", JsonUtility.ToJson(LocalPlayer.local_player));
        
        logged_in = true;
        playing = false;
        in_lobby = false;
        game_over = false;

        LoginUI.SetActive(false);
        LobbyUI.SetActive(true);
        GameUI.SetActive(false);
        GameOverUI.SetActive(false);
    }

}
