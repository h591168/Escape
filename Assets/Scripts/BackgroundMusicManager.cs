using UnityEngine;

public class BackgroundMusicManager : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource component
    public AudioClip backgroundMusic; // Reference to the AudioClip for background music

    private void Awake()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }

        if (audioSource != null && backgroundMusic != null)
        {
            Debug.Log("Assigning background music to audio source.");
            audioSource.clip = backgroundMusic;
            audioSource.loop = true;
            audioSource.playOnAwake = true;
            Debug.Log("Playing background music.");
            audioSource.Play();
            Debug.Log("Is AudioSource Playing: " + audioSource.isPlaying);
        }
        else
        {
            Debug.LogWarning("AudioSource or BackgroundMusic is not assigned.");
        }
    }
}
