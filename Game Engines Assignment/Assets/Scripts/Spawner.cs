using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Camera camera;
    public GameObject cube;

	// Use this for initialization
	void Start () {
        Vector3 position = new Vector3(.5f, .5f, 5f);
        position = camera.ViewportToWorldPoint(position);
        GameObject gameObject = GameObject.Instantiate<GameObject>(cube, position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
