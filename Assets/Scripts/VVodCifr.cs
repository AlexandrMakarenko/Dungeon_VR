using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class VVodCifr : MonoBehaviour
{
    public Text VLogin = null;
    public Text VPassword = null;
    //public GameObject name;
    public GameObject klavaWithOutCaps = null;
    public GameObject klavaWithCaps = null;

    private bool enter = true;
    private string login;
    private string password;

    public void Enter()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
        enter = !enter;
        //    }
        //}
    }
    public void SetSymbol1()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
        if (enter == true)
        {
            VLogin.text = VLogin.text + "1";
        }

        else
        {
            VPassword.text = VPassword.text + "1";
        }
        //    }
        //}
    }

    public void SetSymbol2()
    {
        if (enter == true)
        {
            VLogin.text = VLogin.text + "2";
        }
        else
        {
            VPassword.text = VPassword.text + "2";
        }
    }
    public void SetSymbol3()
    {
        if (enter == true)
        {
            VLogin.text = VLogin.text + "3";
        }
        else
        {
            VPassword.text = VPassword.text + "3";
        }
    }
    public void SetSymbol4()
    {
        if (enter == true)
        {
            VLogin.text = VLogin.text + "4";
        }
        else
        {
            VPassword.text = VPassword.text + "4";
        }
    }
    public void SetSymbol5()
    {
        if (enter == true)
        {
            VLogin.text = VLogin.text + "5";
        }
        else
        {
            VPassword.text = VPassword.text + "5";
        }
    }
    public void SetSymbol6()
    {
        if (enter == true)
        {
            VLogin.text = VLogin.text + "6";
        }
        else
        {
            VPassword.text = VPassword.text + "6";
        }
    }
    public void SetSymbol7()
    {
        if (enter == true)
        {
            VLogin.text = VLogin.text + "7";
        }
        else
        {
            VPassword.text = VPassword.text + "7";
        }
    }
    public void SetSymbol8()
    {
        if (enter == true)
        {
            VLogin.text = VLogin.text + "8";
        }
        else
        {
            VPassword.text = VPassword.text + "8";
        }
    }
    public void SetSymbol9()
    {
        if (enter == true)
        {
            VLogin.text = VLogin.text + "9";
        }
        else
        {
            VPassword.text = VPassword.text + "9";
        }
    }
    public void SetSymbol0()
    {
        if (enter == true)
        {
            VLogin.text = VLogin.text + "0";
        }
        else
        {
            VPassword.text = VPassword.text + "0";
        }
    }
    public void SetSymbolOs()
    {
        if (enter == true)
        {
            VLogin.text = VLogin.text + "(";
        }
        else
        {
            VPassword.text = VPassword.text + "(";
        }
    }
    public void SetSymbolCs()
    {
        if (enter == true)
        {
            VLogin.text = VLogin.text + ")";
        }
        else
        {
            VPassword.text = VPassword.text + ")";
        }
    }
    public void SetSymboltire()
    {
        if (enter == true)
        {
            VLogin.text = VLogin.text + "-";
        }
        else
        {
            VPassword.text = VPassword.text + "-";
        }
    }

    public void SetSymbolpod()
    {
        if (enter == true)
        {
            VLogin.text = VLogin.text + "_";
        }
        else
        {
            VPassword.text = VPassword.text + "_";
        }
    }
}
