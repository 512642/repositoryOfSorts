using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
    public GameObject player;
    public GameObject coin;

    public Rigidbody coinrb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.name == "firstPersonPlayer")
        {
            Destroy(coin);
        }
    }
}
