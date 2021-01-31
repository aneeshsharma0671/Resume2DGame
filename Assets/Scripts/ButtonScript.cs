using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using System.Runtime.InteropServices;

public class ButtonScript : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void OpenNewTab(string url);

    public void openIt(string url)
    {
#if !UNITY_EDITOR && UNITY_WEBGL
             OpenNewTab(url);
#endif
    }


    public Button Button;
    public string URL;
    public float Button_cool;
    public void Awake()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Button.interactable = true;
        //    Debug.Log(collision.gameObject + " entered");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        
        if(collision.gameObject.tag == "Player")
        {
            Button.interactable = false;
          //  Debug.Log(collision.gameObject + " exit");
        }
    }

    public void OnAction(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if (Button.interactable && Button_cool<=0)
            {
                TaskOnClick();
                Button_cool = 2;
                Button.interactable = false;
                Debug.Log("pressed");
            }
        }
    }

    public void TaskOnClick()
    {
        Debug.Log("open");
         openIt(URL);
        
    }

    public void Update()
    {
        if(Button_cool > 0)
        {
            Button_cool -= Time.deltaTime;
        }
    }


}
