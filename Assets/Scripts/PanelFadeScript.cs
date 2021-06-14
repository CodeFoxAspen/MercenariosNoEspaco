using UnityEngine;

public class PanelFadeScript : MonoBehaviour
{
  public void Fade() {
    var canvGroup = GetComponent<CanvasGroup>();
    MenuFadeManager.Instance.Fade(canvGroup);
  }
}
