using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour {

    GameObject audioAnalyser;
    Analyser analyser;
    float boost;

	// Use this for initialization
	void Start () {
        audioAnalyser = GameObject.Find("AudioAnalyser");
        analyser = audioAnalyser.GetComponent<Analyser>();
        boost = 5f;
        GetComponent<Renderer>().material.EnableKeyword("_EMISSION");
    }
	
	// Update is called once per frame
	void Update () {
        Vector3 scale = transform.localScale;
        scale.x = analyser.bassAmplitude * boost;
        scale.y = analyser.bassAmplitude * boost;
        scale.z = analyser.bassAmplitude * boost;

        transform.localScale = Vector3.Lerp(transform.localScale, scale, .2f);
    }
}
