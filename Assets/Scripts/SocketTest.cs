using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketTest : MonoBehaviour
{

    public void OnSocketActivated(SelectEnterEventArgs info)
    {
        if(info.interactableObject.transform.CompareTag("flashlight"))
        
        {
            Debug.Log("YEAHH!!");
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
