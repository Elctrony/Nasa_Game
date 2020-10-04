using UnityEngine;

public class CameraLock : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    public float smoothSpeed = 2f;

    private void LateUpdate()
    {
        transform.rotation = Quaternion.Euler(target.rotation.eulerAngles.x,target.rotation.eulerAngles.y,0f);
    
    }
}