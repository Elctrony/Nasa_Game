using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other) {
        string tag = other.gameObject.tag;
        Debug.Log("Collied");
        if(tag=="Finish"){
            Debug.Log("Enemy collied");
        }
    }
   
    private void OnTriggerEnter(Collider other)
    {
                Debug.Log("Trigged");

    }    
    
}
