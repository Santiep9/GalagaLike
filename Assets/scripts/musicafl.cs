using UnityEngine;

public class BGMManager : MonoBehaviour
{
    public AudioClip bgmClip; // Arrastra aquí tu canción desde Assets
    private AudioSource audioSource;

    void Awake()
    {
        // Si quieres que persista entre escenas, descomenta la siguiente línea:
        // DontDestroyOnLoad(gameObject);

        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = bgmClip;
        audioSource.loop = true;
        audioSource.playOnAwake = false;
    }

    void Start()
    {
        if (bgmClip != null)
            audioSource.Play();
    }
}