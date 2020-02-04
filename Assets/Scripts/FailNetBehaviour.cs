using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailNetBehaviour : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        print(other.gameObject);
        if (other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
