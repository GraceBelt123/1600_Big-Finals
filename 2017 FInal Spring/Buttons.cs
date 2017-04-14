using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

//To get starting, myCharacter and Answer as a number. my best options are to click as to add and Ac or enter as return. Like I've done with FunctionsWithReturns and Math Operators including ElseClause.
//How do I equality? I found my way to do this Answer.Add("number");. 
//As for return, example = 10 + 10; which is equal to 20 as a return but how can I do that?
// To do this if(myNumber == "1") { i.Add("1");} but it shows error. This is int for numbers but unsure to do the same thing as like ElseClause ( if (myCharacter == "+") and other thing ). A different loop. 

public class Buttons : MonoBehaviour {

    public string myCharacters;
    public List<string> myAnswer;
    public float i;
    public InputField myInput;
    
    


    // Use this for initialization
    public void Function (string myCharacters)
    {

        if (myCharacters == "+")
        {
            myAnswer.Add("+");
        }

        if (myCharacters == "/")
        {
           myAnswer.Add("/");
        }

        if (myCharacters == "*")
        {
            myAnswer.Add("*");
        }
        
        if (myCharacters == "-")
        {
            myAnswer.Add("-");
            
        }

        if (myCharacters == " ")
        {
            float i = float.Parse(myCharacters);
            
            return i;
        }

        
    }

    public void ButtonClick()
    {
        foreach (string myCharacters in myAnswer)
        {
            print(myAnswer);
        }
    }
}

