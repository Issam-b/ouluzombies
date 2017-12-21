using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombiwSpawner : MonoBehaviour {
    public float MaxNumberOfZombies; //Maximum number of zombies spawned by the spawner.
    public float maxScene; //Max number of zombies in the scene at the same time.
    public float currentScene; //Current number of zombies in the scene at the same time.

    public GameObject [] zombies; //0 normal zombie, 1 Epic zombie.
    public bool HasEpicZombies; // if should spawn an Epic zombie or not.
    float generated; //number of zombies already generated
    GameObject player; 
	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");	
	}
    void Update()
        {
        if (Vector3.Distance(this.transform.position, player.transform.position) <= 20)
            {
            Spawener();
            }
        else
            {
            return;
            }
        }
    // Update is called once per frame
    void Spawener () {
        if (generated < MaxNumberOfZombies && currentScene < maxScene)
            {
            GameObject clone = Instantiate(zombies[0], gameObject.transform.position, Quaternion.identity);
            generated++;
            currentScene++;
            }
        }
}
