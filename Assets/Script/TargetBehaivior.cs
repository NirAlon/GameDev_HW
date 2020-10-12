using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TargetBehaivior : MonoBehaviour
{
    public NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        Vector3 new_location = new Vector3();

        new_location.x = Random.Range(-300f, 600f);
        new_location.z = Random.Range(-200f, 300);
        new_location.y = Terrain.activeTerrain.SampleHeight(new_location);

        transform.position = new_location;
        agent.SetDestination(new_location);
    }
}
