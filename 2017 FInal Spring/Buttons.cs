﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class Buttons : MonoBehaviour
{
    public InputField Sir;
    public InputField super;
    public InputField dogs;
  

    public void AddButton()
    {
        float sum;
        sum = float.Parse(Sir.text) + float.Parse(super.text);
        dogs.text = sum.ToString();
    }

    public void AddCharacter()
    {
        float sub;
        sub = float.Parse(Sir.text) - float.Parse(super.text);
        dogs.text = sub.ToString();
    }

    public void AddBalls()
    {
        float multiple;
        multiple = float.Parse(Sir.text) * float.Parse(super.text);
        dogs.text = multiple.ToString();
    }

    public void AddDays()
    {
        float divide;
        divide = float.Parse(Sir.text) / float.Parse(super.text);
        dogs.text = divide.ToString();
    }
}
