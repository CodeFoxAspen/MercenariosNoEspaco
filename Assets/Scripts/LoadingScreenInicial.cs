using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingScreenInicial : MonoBehaviour
{
    [SerializeField]
    private Image _progressBar;
    public float loadDuration = 2.0f;
    public float secondsToWait = 3.0f;
    public int sceneIdToLoad = 1;
    private IEnumerator Start()
    {
        StartCoroutine(RunProgressBar());
        yield return new WaitForSeconds(secondsToWait);
        SceneManager.LoadScene(sceneIdToLoad);
    }

    private IEnumerator RunProgressBar()
    {
        float counter = 0f;

        while (counter < loadDuration)
        {
            counter += Time.deltaTime;
            _progressBar.fillAmount = Mathf.Lerp(0, 1, counter / loadDuration);

            yield return null;
        }
        yield return 1;
    }
}
