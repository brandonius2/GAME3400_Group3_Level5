using UnityEngine;
using System.Collections;

public class RandomAudioPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] clips;

    void Start()
    {
        StartCoroutine(PlayRandomClips());
    }

    IEnumerator PlayRandomClips()
    {
        while (true)
        {
            if (clips.Length > 0)
            {
                AudioClip clip = clips[Random.Range(0, clips.Length)];
                audioSource.PlayOneShot(clip);
            }

            float waitTime = Random.Range(1f, 2f);
            Debug.Log("Wait Time: " +  waitTime);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
