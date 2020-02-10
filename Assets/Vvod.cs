using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;
using UnityEngine.UI;
using System;

public class Vvod : MonoBehaviour
{
    public Text VLogin = null;
    public Text VPassword = null;
    //public GameObject name;
    public GameObject klavaWithOutCaps = null;
    public GameObject klavaWithCaps = null;
    public InputField Ilogin = null;

    private bool enter = true;
    private string login;
    private string password;

    // сделать функцию на каждую кнопку?
    // бред и долго
    public void SetSymbolq()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "q";
                }

                else
                {
                    VPassword.text = VPassword.text + "q";
                }
        //    }
        //}
    }

    public void SetSymbolw()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "w";
                }

                else
                {
                    VPassword.text = VPassword.text + "w";
                }
        //    }
        //}
    }
    public void SetSymbole()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "e";
                }

                else
                {
                    VPassword.text = VPassword.text + "e";
                }
        //    }
        //}
    }
    public void SetSymbolr()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "r";
                }

                else
                {
                    VPassword.text = VPassword.text + "r";
                }
        //    }
        //}
    }
    public void SetSymbolt()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "t";
                }

                else
                {
                    VPassword.text = VPassword.text + "t";
                }
        //    }
        //}
    }

    public void SetSymboly()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "y";
                }

                else
                {
                    VPassword.text = VPassword.text + "y";
                }
        //    }
        //}
    }
    public void SetSymbolu()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "u";
                }

                else
                {
                    VPassword.text = VPassword.text + "u";
                }
        //    }
        //}
    }

    public void SetSymboli()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "i";
                }

                else
                {
                    VPassword.text = VPassword.text + "i";
                }
        //    }
        //}
    }

    public void SetSymbolo()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "o";
                }

                else
                {
                    VPassword.text = VPassword.text + "o";
                }
        //    }
        //}
    }

    public void SetSymbolp()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "p";
                }

                else
                {
                    VPassword.text = VPassword.text + "p";
                }
        //    }
        //}
    }

    public void SetSymbola()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "a";
                }

                else
                {
                    VPassword.text = VPassword.text + "a";
                }
        //    }
        //}
    }
    public void SetSymbols()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "s";
                }

                else
                {
                    VPassword.text = VPassword.text + "s";
                }
            }
    //    }
    //}
    public void SetSymbold()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "d";
                }

                else
                {
                    VPassword.text = VPassword.text + "d";
                }
        //    }
        //}
    }

    public void SetSymbolf()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "f";
                }

                else
                {
                    VPassword.text = VPassword.text + "f";
                }
        //    }
        //}
    }
    public void SetSymbolg()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "g";
                }

                else
                {
                    VPassword.text = VPassword.text + "g";
                }
        //    }
        //}
    }

    public void SetSymbolh()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "h";
                }

                else
                {
                    VPassword.text = VPassword.text + "h";
                }
        //    }
        //}
    }

    public void SetSymbolj()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "j";
                }

                else
                {
                    VPassword.text = VPassword.text + "j";
                }
        //    }
        //}
    }
    public void SetSymbolk()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "k";
                }

                else
                {
                    VPassword.text = VPassword.text + "k";
                }
        //    }
        //}
    }

    public void SetSymboll()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "l";
                }

                else
                {
                    VPassword.text = VPassword.text + "l";
                }
            }
    //    }
    //}

    public void SetSymbolz()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "z";
                }

                if (enter == false)
                {
                    VPassword.text = VPassword.text + "z";
                }
            }
      //  }
    //}
    public void SetSymbolx()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "x";
                }

                else
                {
                    VPassword.text = VPassword.text + "x";
                }
        //    }
        //}
    }

    public void SetSymbolc()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "c";
                }

                else
                {
                    VPassword.text = VPassword.text + "c";
                }
        //    }
        //}
    }
    public void SetSymbolv()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "v";
                }

                else
                {
                    VPassword.text = VPassword.text + "v";
                }
        //    }
        //}
    }
    public void SetSymbolb()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "b";
                }

                else
                {
                    VPassword.text = VPassword.text + "b";
                }
        //    }
        //}
    }
    public void SetSymboln()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "n";
                }

                else
                {
                    VPassword.text = VPassword.text + "n";
                }
        //    }
        //}
    }
    public void SetSymbolm()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "m";
                }

                else
                {
                    VPassword.text = VPassword.text + "m";
                }
        //    }
        //}
    }
    public void SetSymbolDot()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + ".";
                }

                else
                {
                    VPassword.text = VPassword.text + ".";
                }
        //    }
        //}
    }

    public void SetSymbolDotcom()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + ".com";
                }

                else
                {
                    VPassword.text = VPassword.text + ".com";
                }
            }
    //    }
    //}

    public void SetSymbolSpace()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + " ";
                }

                else
                {
                    VPassword.text = VPassword.text + " ";
                }
        //    }
        //}
    }
    public void CAPS()
    {
        //for (int handIndex = 0; handIndex < Player.instance.hands.Length; handIndex++)
        //{
        //    Hand hand = Player.instance.hands[handIndex];
        //    if (hand != null)
        //    {
                if (Caps.caps == false)
                {
                    //klavaWithCaps.SetActive = true;

                }
        //    }
        //}
    }

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

    public void DeleteSymbol()
    {

        if (enter == true)
        {
            //char[] chars = VLogin.text.ToCharArray();
            //// int dli = chars.Length;
            //Array.Resize(ref chars, chars.Length - 1);
            //VLogin.text = chars.ToString();
           // VLogin.text = VLogin.text.Length - 1;

        }
        else
        {
            VPassword.text = VPassword.text;
        }
    }

    
}
