using System;
using UnityEngine;

using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    public UnityEvent OnSpacePressed = new UnityEvent();
    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //listens for space key 
            OnSpacePressed?.Invoke();
            //Invoke() -> calls all functions subrcibed to this event
        }
    }
}
