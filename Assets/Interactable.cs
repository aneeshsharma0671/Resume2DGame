using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Interactions;
using UnityEngine.Events;

public abstract class Interactable : MonoBehaviour
{
    public bool InRange;
    public GameObject interectUIPrefab;
    public float UIheight;

    public UnityEvent interactionEvent;
    GameObject interectUI;

    public float coolDownTime = 2f;
    public float coolDown = 0f;
    public bool canInterect;

    private void Start()
    {
        interectUI = Instantiate(interectUIPrefab, gameObject.transform.position +new Vector3(0,UIheight,0), gameObject.transform.rotation);
        interectUI.SetActive(false);
    }

    private void Update()
    {
        if(InRange && canInterect)
        {
            if(Movement.instance.ActionIsPressed)
            {
                interact();
                coolDown = coolDownTime;
            }
            
        }

        if(coolDown >= 0)
        {
            coolDown -= Time.fixedDeltaTime;
            canInterect = false;
        }
        else
        {
            canInterect = true;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            InRange = true;
            interectUI.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            InRange = false;
            interectUI.SetActive(false);
        }
    }
    public abstract void interact();
}
