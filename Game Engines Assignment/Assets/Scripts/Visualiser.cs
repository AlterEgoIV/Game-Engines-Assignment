using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Visualiser : MonoBehaviour {

    public Camera camera;
    public GameObject audioAnalyser;
    public GameObject cube;
    List<GameObject> cubes;
    Analyser analyser;
    int spawnRate, timeLeft;
    public int objectsPerSpawn;

	// Use this for initialization
	void Start () {
        analyser = audioAnalyser.GetComponent<Analyser>();
        cubes = new List<GameObject>();
        spawnRate = 1;
        timeLeft = spawnRate;
        objectsPerSpawn = 5;
    }
	
	// Update is called once per frame
	void Update () {
        --timeLeft;

        if(timeLeft == 0)
        {
            timeLeft = spawnRate;

            for(int i = 0; i < objectsPerSpawn; ++i)
            {
                CreateObject(cube, Random.value, Random.value, 100f);
            }
        }
	}

    void CreateObject(GameObject prefab, float x, float y, float z)
    {
        Vector3 position = new Vector3(x, y, z);
        position = camera.ViewportToWorldPoint(position);
        GameObject gameObject = GameObject.Instantiate<GameObject>(prefab, position, Quaternion.identity);
        gameObject.GetComponent<Renderer>().material.SetColor("_EmissionColor", Color.HSVToRGB(camera.WorldToViewportPoint(gameObject.transform.position).x, 1, 1));
        cubes.Add(gameObject);
    }
}
