using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitReciver : MonoBehaviour
{
    // Called when the player ray hits this object
    public void OnRayHit()
    {
        Debug.Log("Foi!");
        // Whatever you want to happen on a ray hit...
    }
}
public class Banner : MonoBehaviour {

    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()    // Or FixedUpdate() for physical stuf
    {
        
    }

    public void OnMouseOverBanner() {
        Debug.Log("'OnMouseOverBanner' was called!");
        audioSource.Play();
    }
}

