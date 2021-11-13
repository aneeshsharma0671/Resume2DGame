using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class CameraTransitionAnimation : MonoBehaviour
{
    public GameObject transitionScreen;
    public AnimationCurve curve;
    public float transitionTime;
    public Color startColor;
    public Color endColor;
    public void OnEnable()
    {
        Actions.OnTeleport += OnTeleportTransition;
    }
    public void OnDisable()
    {
        Actions.OnTeleport -= OnTeleportTransition;
    }

    public void OnTeleportTransition()
    {
        Debug.Log("Teleport Transition");
        LeanTween.value(transitionScreen, startColor, endColor, transitionTime).setLoopCount(2).setEase(curve).setLoopPingPong().setOnUpdateColor((_color) =>
           {
               transitionScreen.GetComponent<Image>().color = _color;
           });
    }
}
