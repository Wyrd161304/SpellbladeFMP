using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolfpathfinding : MonoBehaviour
{
    public Rigidbody rb;
    public Transform target;

    UnityEngine.AI.NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        rb.velocity = Vector3.zero;
    }
    
}
