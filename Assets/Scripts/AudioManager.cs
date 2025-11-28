using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("Audio Sources")]
    [SerializeField] AudioSource backgroundMusicSource;
    [SerializeField] AudioSource sfxSource;

    [Header("Audio Clips")]
    public AudioClip backgroundMusicClip;
    public AudioClip clickSFXClip;

    public static AudioManager Instance; //biar gk dobel dobel lagunya

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        backgroundMusicSource.clip = backgroundMusicClip;
        backgroundMusicSource.Play();
    }
}
