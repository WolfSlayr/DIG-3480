using UnityEngine;
using UnityEngine.InputSystem;

public class FirePoint : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.wKey.wasPressedThisFrame) 
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 90f);
        }
        if(Keyboard.current.aKey.wasPressedThisFrame) 
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 180f);
        }
        if(Keyboard.current.sKey.wasPressedThisFrame)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 270f);
        }
        if(Keyboard.current.dKey.wasPressedThisFrame) 
        {
           transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
}
