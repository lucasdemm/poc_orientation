using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera cam;

    void Start()
    {

       cam = gameObject.GetComponent<Camera>();
       
    }

    void Update()
    {   

        if(Screen.width < Screen.height) 
            cam.orthographicSize = 9;
        
        if(Screen.width > Screen.height)
            cam.orthographicSize = 5;  
        
    }
}
