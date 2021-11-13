using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonDialogueTrigger : DialogueTrigger
{
    public override void TriggerDialogue()
    {
        base.TriggerDialogue();
        Debug.Log("Trigger ConvoStart");
    }

    public override void OnEndConversation()
    {
        base.OnEndConversation();
        Debug.Log("Start Movenment");
        Debug.Log(" Convo EnD");
        Movement.instance.canMove = true;
    }
}
