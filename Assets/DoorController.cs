using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : Interactable
{
    public bool defaultOpen = false;
    bool IsOpen = false;
    Animator anim;

    public Transform teleportTo;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        if(defaultOpen)
        {
            anim.SetBool("DoorOpen", true);
        }
    }


    public override void interact()
    {
        interactionEvent.Invoke();
        StartCoroutine(Teleport());
    }

    public void OpenDoor()
    {
        Debug.Log("OpenDoor");
        IsOpen = true;

        anim.SetBool("DoorOpen", IsOpen);

    }

    IEnumerator Teleport()
    {
        Debug.Log("teleport");
        Actions.OnTeleport?.Invoke();
        yield return new WaitForSeconds(0.65f);
        Movement.instance.gameObject.transform.position = new Vector3(teleportTo.position.x, Movement.instance.gameObject.transform.position.y, 0);
    }
}
