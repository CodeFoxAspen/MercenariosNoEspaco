using System.Collections;
using UnityEngine;

public class MenuFadeManager : MonoBehaviour
{
  public static MenuFadeManager Instance {get; private set; }

  private CanvasGroup currentOpenedMenu = null;
  public float Duration = 0.4f;

  private void Awake() {
    if (Instance == null) {
      Instance = this;
      DontDestroyOnLoad(gameObject);
    }
    else {
      Destroy(gameObject);
    }
  }

  public void Fade(CanvasGroup canvGroup) {
    var targetIsCurrentMenuObject = currentOpenedMenu == canvGroup;
    var closeCurrentMenuAndOpenOther = currentOpenedMenu != canvGroup;
    var noMenuCurrentlyOpen = currentOpenedMenu == null;

    if (targetIsCurrentMenuObject) {
      Debug.Log("Switch");
      StartCoroutine(DoFade(canvGroup, 1, 0));
      currentOpenedMenu = null;

    } else if (closeCurrentMenuAndOpenOther && !noMenuCurrentlyOpen) {
      Debug.Log("Swap");
      StartCoroutine(DoFade(currentOpenedMenu, 1, 0));
      currentOpenedMenu = null;
      StartCoroutine(DoFade(canvGroup, 0, 1));
      currentOpenedMenu = canvGroup;

    } else if (noMenuCurrentlyOpen) {
      Debug.Log("Open New");
      StartCoroutine(DoFade(canvGroup, 0, 1));
      currentOpenedMenu = canvGroup;
    }
  }

  public IEnumerator DoFade(CanvasGroup canvGroup, float start, float end) {
    float counter = 0f;

    while (counter < Duration) {
      counter += Time.deltaTime;
      canvGroup.alpha = Mathf.Lerp(start, end, counter / Duration);

      yield return null;
    }
  }

}
