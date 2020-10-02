using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLock : MonoBehaviour
{
    public Transform cam;
    public float CamDistance;
    float mouseXSmooth = 0;
    float mouseYSmooth = 0;
    Quaternion lookRotation;


    // Start is called before the first frame update
    void Start()
    {
        lookRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        
        Quaternion localRotation = Quaternion.Euler(0,0, 0);
        lookRotation = localRotation;
        cam.rotation = lookRotation;
    }
}