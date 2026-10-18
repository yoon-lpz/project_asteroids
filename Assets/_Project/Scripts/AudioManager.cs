using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioSource audioSource;
    public AudioClip ShootSound;
    public AudioClip AsteroidDestroy;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else Destroy(gameObject);
    }

    public void PlayShootSound() => audioSource.PlayOneShot(ShootSound);
    public void PlayAsteroidDestroySound() => audioSource.PlayOneShot(AsteroidDestroy);
}
