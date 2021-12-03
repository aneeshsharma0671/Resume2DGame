using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleTween : MonoBehaviour
{
    public LeanTweenType easeType;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.localScale = new Vector3(0, 0, 0);
        LeanTween.scale(gameObject, new Vector3(1, 1, 1), 0.5f).setEase(easeType);
    }

    public void OnClose()
    {
        LeanTween.scale(gameObject, new Vector3(0, 0, 0), 0.5f).setEase(easeType).setOnComplete(DestroyMe);
    }

    void DestroyMe()
    {
        Destroy(gameObject.transform.parent.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
