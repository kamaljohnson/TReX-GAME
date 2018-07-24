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
    public InputField password_field;

    public Button SubmitButton;

    private void Start()
    {
        SubmitButton.onClick.AddListener(GameLogin);
        password_field.inputType = InputField.InputType.Password;
    }
    private string user_name;
    private string password;

    public void GameLogin()
    {
        Debug.Log("checking. . .");
        user_name = user_name_text.text;
        password = password_field.text;
        //checking if fields blank
        if (user_name != "" && password != "")
        {
            //  TODO: pass the username and password to the server and get back the player profile 
            //    var response = new WebClient().DownloadString("127.0.0.1:8000/data");
            //    Debug.Log(response);
            Debug.Log(password);
        }
    }
    
}
