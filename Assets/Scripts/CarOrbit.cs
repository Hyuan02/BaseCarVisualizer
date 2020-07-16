using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarOrbit : MonoBehaviour
{
    float x;

    [SerializeField]
    float xSpeed = 120.0f;

    [SerializeField]
    float xMaxLimit = 360f;
    void Start(){
        Vector3 angles = transform.eulerAngles;
        

    } 

    void LateUpdate(){
        if(Input.GetMouseButton(0)){
            x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
            Quaternion rotation = Quaternion.Euler(transform.eulerAngles.x, ClampAngle(x, 0, xMaxLimit), transform.eulerAngles.z);
            transform.rotation = rotation;
        }
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }
}
