using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

    Camera camera;
    GameObject audioAnalyser;
    Analyser analyser;
    float speed;

	// Use this for initialization
	void Start () {
        speed = Random.Range(400f, 600f);
        transform.forward = -Vector3.forward;
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
        audioAnalyser = GameObject.Find("AudioAnalyser");
        analyser = audioAnalyser.GetComponent<Analyser>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, analyser.bassAmplitude * speed * Time.deltaTime);

        if(transform.position.z < camera.transform.position.z - 10)
        {
            Destroy(this.gameObject);
        }
	}
}
