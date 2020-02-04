using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TrainStationBehaviour : MonoBehaviour
{
    public Animator animationCurtain;
    public Text coalCollectedText;
    public SurfaceEffector2D accelerator;
    public int coalCollected;

    void OnTriggerEnter2D(Collider2D other)
    {
        print(other.gameObject.tag);
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(nextLevel());
        }else if (other.gameObject.CompareTag("Coal"))
        {
            coalCollected++;
        }
    }

    IEnumerator nextLevel()
    {
        yield return new WaitForSeconds(1f);
        animationCurtain.SetBool("end", true);
        coalCollectedText.enabled = true;
        coalCollectedText.text = "Coal Collected: " + coalCollected;
        accelerator.speed = 0;
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
