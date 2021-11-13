using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverController : Interactable
{
    Animator anim;
    bool IsOpen = true;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    public override void interact()
    {
        Debug.Log("lever pressed");
        if(IsOpen)
        interactionEvent.Invoke();
        IsOpen=!IsOpen;

        anim.SetBool("IsOpen", IsOpen);
        
    }
}
