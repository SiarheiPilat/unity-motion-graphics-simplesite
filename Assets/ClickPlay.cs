using UnityEngine;

public class ClickPlay : MonoBehaviour
{
    public AudioClip clip1, clip2;


    public AudioSource AudioSource;

    public void PlayClip1()
    {
        AudioSource.PlayOneShot(clip1);
    }

    public void PlayClip2()
    {
        AudioSource.PlayOneShot(clip2);
    }
}
