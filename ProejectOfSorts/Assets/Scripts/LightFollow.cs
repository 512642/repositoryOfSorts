using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFollow : MonoBehaviour
{


    public Transform camera;


    void FixedUpdate()
    {
        transform.localRotation = camera.localRotation;
    }


}
