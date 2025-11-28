using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{

    AudioManager audioManager;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    public void OnStartClick()
    {   
        audioManager.PlaySFX(audioManager.clickSFXClip);
        SceneManager.LoadScene("Day 2");
    }

    public void SelectRed()
    {
        audioManager.PlaySFX(audioManager.clickSFXClip);
        PlayerPrefs.SetString("SelectedLibrary", "Red");
        SceneManager.LoadScene("Day 2");
    }

    public void SelectBlue()
    {
        audioManager.PlaySFX(audioManager.clickSFXClip);
        PlayerPrefs.SetString("SelectedLibrary", "Blue");
        SceneManager.LoadScene("Day 2");
    }

    public void OnExitClick()
    {
        audioManager.PlaySFX(audioManager.closeSFXClip);
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
        Application.Quit();
    }
}
