using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinusPlus : MonoBehaviour
{

    public int number;
    public Text numberText;
   

    public void plusOne()
    {
        number += 1;
        Debug.Log(number);
    }

    public void minusOne()
    {
        number -= 1;
        Debug.Log(number);
    }

    public void square()
    {
        number *= number;
    }

    public void Update()
    {
        numberText.text = number.ToString();
    }

}
