using System.Collections.Generic;
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
    public Text feeds_text;

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
            player.username = user_name;
            player.password = password;

            string response = new WebClient().UploadString("http://192.168.43.10:8000/lobby/login", JsonUtility.ToJson(player));
            print(response);
            player = JsonUtility.FromJson<Player>(response);

            if (player.username != null && player.password == "")
            {
                NotificationLogger.Load("username taken");
            }
            else if(player.username != null && player.letters_typed != 0)
            {
                LocalPlayer.local_player = player;
                NotificationLogger.Load("welcome back " + LocalPlayer.local_player.username);
                FindObjectOfType<GameManager>().Login();
            }
            else
            {
                LocalPlayer.local_player = player;
                NotificationLogger.Load("loggend in as " + LocalPlayer.local_player.username);
                FindObjectOfType<GameManager>().Login();
            }
        }
    }
}



