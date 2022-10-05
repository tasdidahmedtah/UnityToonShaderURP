using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotaion : MonoBehaviour
{
    public float Speed;
    public Rigidbody rb;
    

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(0, Speed * Time.deltaTime, 0);
    }
}
