using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public List<AudioClip> musucs = new List<AudioClip>();
    private AudioSource sourse;
    private float time_clip; 
    IEnumerator playAudio()
{
        sourse.clip = musucs[0];
        sourse.Play();
        yield return new WaitForSeconds(sourse.clip.length);
        Debug.Log(playAudio());
        Music_Completion();
}
    private void Start() 
    {
        sourse = gameObject.GetComponent<AudioSource>();
        StartCoroutine(playAudio());
    }
    private void Music_Completion()
    {
        StartCoroutine(playAudio());
    }
    public void Audio_Play()
    {
        
    }
    public void Audio_Stop()
    {
        sourse.Stop();
    }
    private void Update() 
    {
        
    }
}
