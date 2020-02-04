using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
  public void playGame(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

  public void credits(){
    SceneManager.LoadScene("Menu");
  }

  public void quitGame(){
    Application.Quit();
  }

  public void playAgain(){
		SceneManager.LoadScene("Level 1");
	}
}
