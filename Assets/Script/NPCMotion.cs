using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class NPCMotion : MonoBehaviour
{
    public GameObject target;
    NavMeshAgent theAgent;
    // Start is called before the first frame update
    void Start()
    {
        theAgent = GetComponent<NavMeshAgent>();
        theAgent.SetDestination(target.transform.position);
        GetComponent<Animation>().Play("run");
    }

    // Update is called once per frame
    void Update()
    {
        if(!GetComponent<Animation>().IsPlaying("run"))
        GetComponent<Animation>().Play("run");
    }
}
