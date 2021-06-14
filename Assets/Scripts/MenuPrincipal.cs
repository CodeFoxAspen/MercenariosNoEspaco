using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
  public void OpenStart()
  {

  }
  public void Playgame()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }

  public void OpenSettings()
  {

  }

  public void OpenCredits()
  {

  }

  public void QuitGame()
  {
    Application.Quit();
  }
}
