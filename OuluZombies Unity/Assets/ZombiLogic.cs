using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ZombiLogic : MonoBehaviour {
	public GameObject target;
	NavMeshAgent ag; 
	// Use this for initialization
	void Start () {
		ag = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		float distanace = Vector3.Distance (target.transform.position,transform.position);

		ag.SetDestination (target.transform.position);
	}
}
