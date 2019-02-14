using UnityEngine;
using System.Collections;

public class RotateLight : MonoBehaviour
{

    public GameObject directionalLight;

    public Animator sunRotationAnimation;

    float startTime = 0f;
    bool isPressed = false;
    string whoRocks = "Udacity Rocks";

    // Use this for initialization
    void Start()
    {
        //GvrViewer.Instance.OnTrigger += ActivateRotation;
        sunRotationAnimation.StartPlayback();
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion startRotation = Quaternion.Euler(50f, 30f, 0f);
        Quaternion endRotation = startRotation * Quaternion.Euler(0f, 180f, 0f);
        if (isPressed == true)
        {
            //directionalLight.transform.rotation = Quaternion.Slerp(startRotation, endRotation, startTime / 10f);
            /*
               //sunRotationAnimation.StartPlayback ();
                sunRotationAnimation.enabled = false; // Disable the Animator component
    
                //sunRotationAnimation.StopPlayback ();
                sunRotationAnimation.enabled = true; // Enable the Animator component

             */
            sunRotationAnimation.StopPlayback();
            startTime += Time.deltaTime;
        }

        // Replaces 'GvrViewer.Instance.OnTrigger += ActivateRotation;'
        // Typically would be placed at the top of the Update() method, but
        // placed here for the script to better match up with the video
        if (Input.GetMouseButtonDown(0))
        {
            ActivateRotation();
        }
    }

    public void ActivateRotation()
    {
        isPressed = true;
        sunRotationAnimation.SetBool("ChangeColor", true);
    }
}