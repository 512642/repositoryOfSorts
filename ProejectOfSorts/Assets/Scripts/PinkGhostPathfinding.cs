using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PinkGhostPathfinding : MonoBehaviour
{   private NavMeshAgent ai;

    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        ai = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        Vector3 dirToPLayer = transform.position - player.transform.position;

        Vector3 newPos = transform.position - dirToPLayer;

        ai.SetDestination(newPos);

        
    }



}
