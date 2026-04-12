using UnityEditor.PackageManager;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    private static audioManager instance;
    public static audioManager Instance { get { return instance; } }

    private AudioSource audioSource;

    private void Awake()
    {
        instance = FindFirstObjectByType<audioManager>();
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    public void playOnShot(AudioClip clip)
    {
        audioSource.PlayOneShot(clip);
    }

}
