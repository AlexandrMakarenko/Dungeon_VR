using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Valve.VR.InteractionSystem;

public class VvodPassRightRoom : MonoBehaviour
{
    public Text passRoom = null;
    public GameObject[] scrit;
    public Text passWord = null;

    public void SetSymbol1()
    {
        passRoom.text += "1";
    }

    public void SetSymbol2()
    {
        passRoom.text += "2";
    }
    public void SetSymbol3()
    {
        passRoom.text += "3";
    }
    public void SetSymbol4()
    {
        passRoom.text += "4";
    }
    public void SetSymbol5()
    {
        passRoom.text += "5";
    }
    public void SetSymbol6()
    {
        passRoom.text += "6";
    }
    public void SetSymbol7()
    {
        passRoom.text += "7";
    }
    public void SetSymbol8()
    {
        passRoom.text += "8";
    }
    public void SetSymbol9()
    {
        passRoom.text += "9";
    }
    public void SetSymbol0()
    {
        passRoom.text += "0";
    }

    public void deleteSymbol()
    {
        passRoom.text = "";
    }

    public void SetPass()
    {
        if(passRoom.text == "1313")
        {
            for(int i = 0; i < scrit.Length; i++)
            {
                scrit[i].SetActive(false);
            }
        }
        else
        {
            passWord.text = "Error";
        }
    }
}
   
