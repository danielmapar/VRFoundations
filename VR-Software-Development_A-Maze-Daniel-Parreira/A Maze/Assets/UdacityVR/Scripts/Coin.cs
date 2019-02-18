using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    // TODO: Create variables to reference the game objects we need access to
    // Declare a GameObject named 'coinPoofPrefab' and assign the 'CoinPoof' prefab to the field in Unity

    public GameObject coinPoofPrefab;

    void Update () {
        // OPTIONAL-CHALLENGE: Animate the coin rotating
        transform.Rotate(0, 120 * Time.deltaTime, 0);
    }


	public void OnCoinClicked () {
		/// Called when the 'Coin' game object is clicked
		/// - Displays a poof effect (handled by the 'CoinPoof' prefab)
		/// - Plays an audio clip (handled by the 'CoinPoof' prefab)
		/// - Removes the coin from the scene

		// Prints to the console when the method is called
		Debug.Log ("'Coin.OnCoinClicked()' was called");
        StartCoroutine(CreateParticleEffect());
    }

    IEnumerator CreateParticleEffect()
    {
        Quaternion effectRotation = Quaternion.Euler(270, 0, 0);
        Object.Instantiate(coinPoofPrefab, transform.position, effectRotation);
        yield return new WaitForSeconds(0.5f);
        GetComponent<Renderer>().enabled = false;
        // Removes the collider from the GameObject (no highlight when mousing over)
        GetComponent<Collider>().enabled = false;
        // Removes this script component from the game object
        Destroy(this);
        
    }
}
