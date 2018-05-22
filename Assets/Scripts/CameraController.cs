using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;

    public Vector3 offset;




	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () { // runs every frame but is guaranteed to run after all updates have been processed
        transform.position = player.transform.position + offset;	
	}
}
