
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/**
 * @author Aidan Cha
 * class Coroutine starts a countdown when the user clicks.
 * I was gonna use coroutines to make randomized AI wandering/idling, but
 * I had a lot of other assignments due this weekend. I can maybe show
 * a better example later. */
public class Coroutine : MonoBehaviour {
    [SerializeField] private GameObject TextBox;

    private void Update() {
        if (Input.GetMouseButtonDown(0)) { // doesn't have debounce for now
            StartCoroutine("ChangeText");
        }
    }
    IEnumerator ChangeText() {
        int total = 5;
        int counter = total;
        while (counter > 0) {
            yield return new WaitForSeconds(1); // reliant on seconds :( srry
            counter--;
            TextBox.GetComponent<Text>().text = counter.ToString();
            
        }
        if (counter <= 0) {
            TextBox.GetComponent<Text>().text = "Waited " + total.ToString() + " seconds"; 
        }
        
    }
}
