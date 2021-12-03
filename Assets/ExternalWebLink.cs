using UnityEngine;
using System.Runtime.InteropServices;

public class ExternalWebLink : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void OpenNewTab(string url);

    public void openLink(string url)
    {
        Debug.Log("Opening Link " + url);
#if !UNITY_EDITOR && UNITY_WEBGL
             OpenNewTab(url);
#endif
    }
}
