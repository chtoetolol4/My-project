using System;
using UnityEngine;

public class Test : MonoBehaviour
{
    public event Action OnChangeText;
    void Start()
    {
        OnChangeText += TextMy;
        OnChangeText += DebugLogText;
        OnChangeText.Invoke();
        TestSomethingNew(777, true);
        Debug.Log(Calculating());
        Debug.Log(Printing( "Hello ", "World!"));
    }

    void TextMy()
    {
        Debug.Log("ключи");
    }

    void DebugLogText()
    {
        Debug.Log(9 + 10);
    }

    void TestSomethingNew(int number, bool decide)
    {
        if (decide == true)
        {
            Debug.Log(number);
        }
    }

    int Calculating(int firstNumber = 1, int secondNumber = 3, int thirdNumber = 6)
    {
        return firstNumber * secondNumber * thirdNumber;
    }

    string Printing(string firstPart, string secondPart) => firstPart + secondPart;

    void Update()
    {
        
    }
}
