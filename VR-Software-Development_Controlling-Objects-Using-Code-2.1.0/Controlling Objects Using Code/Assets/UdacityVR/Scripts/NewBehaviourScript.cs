using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public GameObject objectToCreate;

	// Use this for initialization
	void Start () {
        for (int i = 0; i < 50; i++) {
            GameObject newSeagull = (GameObject)Object.Instantiate(objectToCreate, new Vector3(i, 0, 0), Quaternion.identity);
            Renderer objectRenderer = newSeagull.GetComponentInChildren<Renderer>();
            objectRenderer.material.color = Color.white * Random.value;
        }
        
        //Object.Instantiate(objectToCreate, new Vector3(2, 4, 5), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
