using UnityEngine;

public class OrientationController : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {

        if(Screen.width < Screen.height && transform.rotation.z <= 0) 
            transform.Rotate(new Vector3(0,0,90));
            
        if(Screen.width > Screen.height && transform.rotation.z > 0) 
            transform.Rotate(new Vector3(0,0,-90));  
        
    }
}
