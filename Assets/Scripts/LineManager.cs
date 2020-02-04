using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LineManager : MonoBehaviour {

	public GameObject linePrefab;
	public LineBehaviour activeLine;
	public Slider inkBottle;
    public int maxInk, decreasingSpeed, increasingSpeed;
	public Rigidbody2D shipRb;

    bool coolOff;

	void Start(){
        inkBottle.maxValue = maxInk;
        inkBottle.value = maxInk;
	}

	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			GameObject line = Instantiate (linePrefab);
			activeLine = line.GetComponent<LineBehaviour> ();
            coolOff = false;
		}

		if (activeLine != null && inkBottle.value > 1 && !coolOff) {
			Vector2 mousePosition = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			activeLine.updateLine (mousePosition);
            inkBottle.value -= decreasingSpeed * Time.deltaTime;
        }
        /*else
        {
            if (inkBottle.value < inkBottle.maxValue && coolOff)
                inkBottle.value += increasingSpeed * Time.deltaTime;
        }*/

		if (Input.GetMouseButtonUp (0)){ 
			activeLine = null;
            coolOff = false;
            StartCoroutine(coolOffStarter());
			Camera.main.GetComponent<CameraBehaviour>().cameraFollow();
			if(shipRb.isKinematic) shipRb.bodyType = RigidbodyType2D.Dynamic;
		}
	}


	public void restartScene(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}

    IEnumerator coolOffStarter()
    {
        yield return new WaitForSeconds(.1f);
        coolOff = true;
    }
}