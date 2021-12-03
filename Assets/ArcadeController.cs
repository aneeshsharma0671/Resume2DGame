using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcadeController : Interactable
{
    public GameObject projectsUIPrefab;
    public override void interact()
    {
        Debug.Log("interect arcade");
        Instantiate(projectsUIPrefab);
    }
}
