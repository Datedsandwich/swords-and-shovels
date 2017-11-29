using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Interactable : MonoBehaviour
{
    [HideInInspector]
    public NavMeshAgent navMeshAgent;
    private bool hasInteracted;

    public virtual void MoveToInteract(NavMeshAgent navMeshAgent)
    {
        this.navMeshAgent = navMeshAgent;
        navMeshAgent.destination = this.transform.position;

        
    }

    void Update()
    {
        if(!hasInteracted && navMeshAgent != null && !navMeshAgent.pathPending)
        {
            if(navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
            {
                    Interact();
                    hasInteracted = true;
            }
        }

    }

    public virtual void Interact()
    {
        print("Interacting with base class.");
    }

}
