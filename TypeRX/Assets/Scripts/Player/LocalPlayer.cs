using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections.Specialized;


public class LocalPlayer  {
    
    public static Player local_player = new Player();

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