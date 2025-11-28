using UnityEngine;
using UnityEngine.UI;

public class UISound : MonoBehaviour
{
    public void PlayClickSound()
    {
        AudioManager.Instance.PlaySFX(AudioManager.Instance.clickSFXClip);
    }
    public void PlayCloseSound()
    {
        AudioManager.Instance.PlaySFX(AudioManager.Instance.closeSFXClip);
    }
}
