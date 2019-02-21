using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int min = 1;
    int max = 1000;
    int guess = 500;
    // Start is called before the first frame update
    void Start()
    {
        // same as print("...")
        Debug.Log("Welcome to number wizard");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than : " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = correct number");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up arrow key was pressed");
            min = guess; 
            Debug.Log(guess);
        } else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down arrow key was pressed");
        } else if(Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter was pressed");
        }
    }
}
