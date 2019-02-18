using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour {

    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();
    }
	
    public void OnClickMonster() {
        Debug.Log("'Monster.OnClickMonster' was called");
        audioSource.Play();
    }
}
