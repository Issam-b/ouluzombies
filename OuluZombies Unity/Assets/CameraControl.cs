using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    public GameObject target;
	// Use this for initialization

	
	// Update is called once per frame
	void Update () {
        gameObject.transform.localPosition = new Vector3(target.transform.localPosition.x+ 20, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z );
        gameObject.transform.LookAt(target.transform);
	}
}
