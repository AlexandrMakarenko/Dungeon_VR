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
       
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "q";
                }

                else
                {
                    VPassword.text = VPassword.text + "q";
                }
    }

    public void SetSymbolw()
    {
       
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "w";
                }

                else
                {
                    VPassword.text = VPassword.text + "w";
                }
    }
    public void SetSymbole()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "e";
                }

                else
                {
                    VPassword.text = VPassword.text + "e";
                }
    }
    public void SetSymbolr()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "r";
                }

                else
                {
                    VPassword.text = VPassword.text + "r";
                }
    }
    public void SetSymbolt()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "t";
                }

                else
                {
                    VPassword.text = VPassword.text + "t";
                }
    }

    public void SetSymboly()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "y";
                }

                else
                {
                    VPassword.text = VPassword.text + "y";
                }
    }
    public void SetSymbolu()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "u";
                }

                else
                {
                    VPassword.text = VPassword.text + "u";
                }
    }

    public void SetSymboli()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "i";
                }

                else
                {
                    VPassword.text = VPassword.text + "i";
                }
    }

    public void SetSymbolo()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "o";
                }

                else
                {
                    VPassword.text = VPassword.text + "o";
                }
    }

    public void SetSymbolp()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "p";
                }

                else
                {
                    VPassword.text = VPassword.text + "p";
                }
    }

    public void SetSymbola()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "a";
                }

                else
                {
                    VPassword.text = VPassword.text + "a";
                }
    }
    public void SetSymbols()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "s";
                }

                else
                {
                    VPassword.text = VPassword.text + "s";
                }
            }
    public void SetSymbold()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "d";
                }

                else
                {
                    VPassword.text = VPassword.text + "d";
                }
    }

    public void SetSymbolf()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "f";
                }

                else
                {
                    VPassword.text = VPassword.text + "f";
                }
    }
    public void SetSymbolg()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "g";
                }

                else
                {
                    VPassword.text = VPassword.text + "g";
                }
    }

    public void SetSymbolh()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "h";
                }

                else
                {
                    VPassword.text = VPassword.text + "h";
                }
    }

    public void SetSymbolj()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "j";
                }

                else
                {
                    VPassword.text = VPassword.text + "j";
                }
    }
    public void SetSymbolk()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "k";
                }

                else
                {
                    VPassword.text = VPassword.text + "k";
                }
    }

    public void SetSymboll()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "l";
                }

                else
                {
                    VPassword.text = VPassword.text + "l";
                }
    }

    public void SetSymbolz()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "z";
                }

                if (enter == false)
                {
                    VPassword.text = VPassword.text + "z";
                }
    }
    public void SetSymbolx()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "x";
                }

                else
                {
                    VPassword.text = VPassword.text + "x";
                }
    }

    public void SetSymbolc()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "c";
                }

                else
                {
                    VPassword.text = VPassword.text + "c";
                }
    }
    public void SetSymbolv()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "v";
                }

                else
                {
                    VPassword.text = VPassword.text + "v";
                }
    }
    public void SetSymbolb()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "b";
                }

                else
                {
                    VPassword.text = VPassword.text + "b";
                }
    }
    public void SetSymboln()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "n";
                }

                else
                {
                    VPassword.text = VPassword.text + "n";
                }
    }
    public void SetSymbolm()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + "m";
                }

                else
                {
                    VPassword.text = VPassword.text + "m";
                }
    }
    public void SetSymbolDot()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + ".";
                }

                else
                {
                    VPassword.text = VPassword.text + ".";
                }
    }

    public void SetSymbolDotcom()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + ".com";
                }

                else
                {
                    VPassword.text = VPassword.text + ".com";
                }
            }

    public void SetSymbolSpace()
    {
                if (enter == true)
                {
                    VLogin.text = VLogin.text + " ";
                }

                else
                {
                    VPassword.text = VPassword.text + " ";
                }
    }
    public void CAPS()
    {
                if (Caps.caps == false)
                {
                    
                }
    }

    public void Enter()
    {
                enter = !enter;
    }

    public void DeleteSymbol()
    {

        if (enter == true)
        {
            int ind = VLogin.text.Length;
            VLogin.text = VLogin.text.Remove(ind - 1);
        }
        else
        {
            int ind = VPassword.text.Length;
            VPassword.text = VPassword.text.Remove(ind - 1);
        }
    }
    public void SetSymbolsobaka()
    {

        if (enter == true)
        {
            VLogin.text = VLogin.text + "@";
        }

        else
        {
            VPassword.text = VPassword.text + "@";
        }
    }

    public void SendData()
    {

    }
}
