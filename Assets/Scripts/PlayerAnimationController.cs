using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(Animator), typeof(NavMeshAgent))]
public class PlayerAnimationController : MonoBehaviour
{
	private Animator animator;
	private NavMeshAgent navMeshAgent;
    // Use this for initialization
    void Start()
    {
		animator = GetComponent<Animator>();
		navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
		animator.SetFloat("PlayerVelocity", navMeshAgent.velocity.magnitude);
    }
}
