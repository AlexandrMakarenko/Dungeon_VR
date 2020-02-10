using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class LOGINMPLACE : MonoBehaviour
{
    private static string Email = "sahka.makar4ik.gta@gmail.com";
    private static string Password = "Makar4ik123";
    private static string Code = "653a9480-39a1-4aaf-8fbd-a5c80118328c8";

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
           
        }
    }

        private static void AuthUser()
        {
        //req = new UnityWebRequest(@"https://mplace.azurewebsites.net/api/v1/login?email=" + Email + "&password=" + Password + "&code" + Code);
        //var answer = req.SendWebRequest();
        //answer.completed += OnRequestCompleted;
        }

    private static void OnRequestCompleted(AsyncOperation obj)
    {
       // if (req.responseCode == 200)
        {
            //если все хорошо открываем доступ к игре
        }
       // else
        {
            //выводим ошибку
        }
    }

}
