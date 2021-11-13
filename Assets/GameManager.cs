using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool IsMobileDevice = false;

    public GameObject mobileControls;

    private void Awake()
    {
        if(instance!=null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
        #if UNITY_STANDALONE && !UNITY_EDITOR
        Debug.Log("Do Build");

        #endif
        
    }


    public void receiveMessage(int IsMobile)
    {
        if(IsMobile == 1)
        {
            IsMobileDevice = true;
        }
        mobileControls.SetActive(IsMobileDevice);
    }
}
