using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WorldInteraction : MonoBehaviour
{
    NavMeshAgent navMeshAgent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

	// Update is called once per frame
	void Update ()
    {
		if(Input.GetMouseButtonDown(0) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject())
            GetInteraction();
	}

    void GetInteraction()
    {
        Ray interactionRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit interactionHit;

        if(Physics.Raycast(interactionRay, out interactionHit))
        {
            GameObject interactedObject = interactionHit.collider.gameObject;
            if(interactedObject.tag == "Interactable")
            {
                interactedObject.GetComponent<Interactable>().MoveToInteract(navMeshAgent);
            }

            else
            {
                navMeshAgent.destination = interactionHit.point;

            }
        }
    }
}
