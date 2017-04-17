using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class Buttons : MonoBehaviour
{
    public InputField Sir;
    public InputField super;
    public InputField dogs;
    public InputField sugar;
    public InputField happy;
    public InputField great;
    public InputField down;
    public InputField up;
    public InputField cheers;
    public InputField hello;
    public InputField sweet;
    public InputField good;

    public void AddButton()
    {
        float sum;
        sum = float.Parse(Sir.text) + float.Parse(super.text);
        dogs.text = sum.ToString();
    }

    public void AddCharacter()
    {
        float sub;
        sub = float.Parse(sugar.text) - float.Parse(happy.text);
        great.text = sub.ToString();
    }

    public void AddBalls()
    {
        float multiple;
        multiple = float.Parse(cheers.text) * float.Parse(down.text);
        up.text = multiple.ToString();
    }

    public void AddDays()
    {
        float divide;
        divide = float.Parse(hello.text) / float.Parse(sweet.text);
        good.text = divide.ToString();
    }
}
