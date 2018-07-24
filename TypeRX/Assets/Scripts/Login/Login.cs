using System.Net;
using UnityEngine;
using UnityEngine.UI;

public class Login : MonoBehaviour {

    /*
     * this funtion is used to login the player
     * login posts the data entered to the login input field
     * to the game server to validate/add the user to the db
     * and get the profile of the user from the server
     * set is_online flag to true in the db
     */

    public Text user_name_text;
    public Text password_text;
    public Button SubmitButton;

    private void Start()
    {
        SubmitButton.onClick.AddListener(GameLogin);
    }
    private string user_name;
    private string password;

    public void GameLogin()
    {
        Debug.Log("checking. . .");
        user_name = user_name_text.text;
        password = user_name_text.text;

        //checking if fields blank
        if (user_name != "" && password != "")
        {
            var response = new WebClient().DownloadString("127.0.0.1:8000/data");
            Debug.Log(response);
        }
    }
    
}
