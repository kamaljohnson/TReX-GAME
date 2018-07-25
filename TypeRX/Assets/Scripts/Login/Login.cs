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

    private void Start()
    {
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
            //  TODO: pass the username and password to the server and get back the player profile 
            //    var response = new WebClient().DownloadString("127.0.0.1:8000/data");
            //    Debug.Log(response);
            Debug.Log(password);
        }
    }
    
}
