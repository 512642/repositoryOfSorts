using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    public Vector2 turn;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        
    }

    void rotate()
    {
        turn.x += Input.GetAxis("Mouse X");        
        transform.localRotation = Quaternion.Euler(-turn.y, turn.x, 0);
    }
}
