using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void onRestart()
    {
        audioManager.PlaySFX(audioManager.clickSFXClip);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void onMenu()
    {
        audioManager.PlaySFX(audioManager.closeSFXClip);
        SceneManager.LoadScene("MainMenu");
    }
}
