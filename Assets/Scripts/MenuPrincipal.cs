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
    LoadingScreenInicial.setSceneIdToLoad(2);
    SceneManager.LoadScene(0);
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
