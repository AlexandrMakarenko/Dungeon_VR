using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Auth : MonoBehaviour
{
    public static bool IsLoggingNow = false;
    public static bool Authorized = false;
    //public static OnlineUser ThisUser;

    public static Text Lfield = null;
    public static Text Pfield = null;

    public static string Email;
    private static string Password;
    private const string Code = "653a9480-39a1-4aaf-8fbd-a5c8018328c8";
    private static UnityWebRequest AuthRequest;

    public static void ConfirmUserData(string email, string password)
    {


        if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(password) && email.Contains("@"))
        {
            Email = email.Replace("\u200B", "");
            Password = password.Replace("\u200B", "");
            AuthUser();
        }
        else
        {
            throw new ArgumentException("Invalid data");
        }
    }

    public static void AuthUser()
    {
        Email = Lfield.ToString();
        Password = Pfield.ToString();

        AuthRequest = UnityWebRequest.Get(@"https://mplace.azurewebsites.net/api/v1/login?email=" + Email
            + "&password=" + Password + "&code=" + Code);
        
        var response = AuthRequest.SendWebRequest();
        response.completed += OnRequestCompleted;
    }

    private static void OnRequestCompleted(AsyncOperation obj)
    {
        IsLoggingNow = false;
        switch (AuthRequest.responseCode)
        {
            case 200:
                Authorized = true;
                break;
            case 400:
                //print("User not found");
                break;
            case 502:
                //print("Bad gateway");
                break;
            default:
                //print(AuthRequest.responseCode + ": troubles with connection");
                break;
        }
    }

    public static void LoadLoginScreen()
    {
        Debug.Log("Выполнен вход");
    }
}
