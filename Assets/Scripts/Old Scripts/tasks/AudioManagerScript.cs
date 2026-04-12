using UnityEngine;

public class AudioManagerScript : SingleTon<AudioManagerScript>
{
    public void playSoundEffect(AudioSource source, AudioClip clip)
    {
        source.PlayOneShot(clip);
    }
}
