using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerAnimManager : MonoBehaviour {

	private Animator anim;
	public NavMeshAgent navMeshAgent;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		navMeshAgent = GetComponent<NavMeshAgent>();

	}
	
	// Update is called once per frame
	void Update () {
		anim.SetFloat ("PlayerVelocity", navMeshAgent.velocity.magnitude);
	}
}
