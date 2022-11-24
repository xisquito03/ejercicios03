using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio01 : MonoBehaviour
{
    public string letter;

    private void Start()
    {
        IsVowel(letter);
    }
    
    private bool IsVowel(string l)
    {
        if (l == "a" || l == "e" || l == "i" || l == "o" || l == "u")
        {
            Debug.Log("The letter is a vowel");
            return true;
        }
        else
        {
            Debug.Log("The letter is not a vowel");
            return false;
        }
    }
}
