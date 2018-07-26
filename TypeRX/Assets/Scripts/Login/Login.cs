using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using UnityEngine;
using UnityEngine.UI;


public class Login : MonoBehaviour {

    #region UI elements
    public InputField user_name_field;
    public InputField password_field;
    public Button SubmitButton;
    #endregion

    private string user_name;
    private string password;

    Player player = new Player();

    private void Start()
    {
        Screen.orientation = ScreenOrientation.Portrait;
        SubmitButton.onClick.AddListener(GameLogin);
        password_field.inputType = InputField.InputType.Password;

    }
    /*
     * this funtion is used to login the player
     * login posts the data entered to the login input field
     * to the game server to validate/add the user to the db
     * and get the profile of the user from the server
     * set is_online flag to true in the db
     */
    public void GameLogin()
    {
        user_name = user_name_field.text;
        password = password_field.text;

        //checking if fields blank
        if (user_name != "" && password != "")
        {
            // TODO: pass the username and password to the server and get back the player profile 
            player.username = user_name;
            player.password = password;
            player.status = "O";

            string response = new WebClient().UploadString("http://127.0.0.1:8000/lobby/show", JsonUtility.ToJson(player));
            print(response);
            player = JsonUtility.FromJson<Player>(response);

            if (player.username != null && player.password == "")
            {
                Debug.Log("username already taken.");
            }
            else if (player.username != null && player.password != "")
            {
                Debug.Log("loged in as : " + player.username );
            }
            else
            {
                Debug.Log("created new account with username : " + player.username);
            }
        }
    }
}

/*
 * this class stores the player profile 
 * while logging-in and end_point is called 
 * which checks if the user has an account 
 * else creates one.
 * is a username matches and the password is not 
 * correct, a login error is created 
 */
[Serializable]
public class Player
{
    public string username;
    public string password;
    public int global_rank;
    public int matches_won;
    public int type_speed;
    public int letters_typed;
    public string status;
    public int local_rank;

}

