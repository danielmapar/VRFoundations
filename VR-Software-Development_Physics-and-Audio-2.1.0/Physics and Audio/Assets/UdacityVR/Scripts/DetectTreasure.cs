using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectTreasure : MonoBehaviour {

    public GameObject chest;
    private Animator chestAnimator;
    private bool chestOpen = false;

    void Start()
    {
        chestAnimator = chest.GetComponent<Animator>();
    }

    void FixedUpdate()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        // We provide our position, the vector the ray will travel and how far we want the ray to travel (10 meters)
        if (Physics.Raycast(transform.position, fwd, 10) && !chestOpen)
        {
            print("There is something in front of the object!");
            chestAnimator.SetTrigger("LookedToChest");
            chestOpen = true;
        }
    }
}
