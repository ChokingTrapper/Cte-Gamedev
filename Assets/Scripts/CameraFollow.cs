using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform carTransform;


    
    Vector3 carPos;
    void LateUpdate()
    {
        carPos = carTransform.position;
        carPos.z = -10f;
        transform.position = carPos;
    }
}
