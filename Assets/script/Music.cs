using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music : MonoBehaviour
{
    public List<AudioClip> musucs = new List<AudioClip>();
    private AudioSource sourse;
    public Slider voluem_Music;
    public Slider voluem_Cub; 
    private Transform cude;
    IEnumerator playAudio()
    {
        sourse.clip = musucs[Random.Range(0,musucs.Count)];
        sourse.Play();
        yield return new WaitForSeconds(sourse.clip.length);
        Audio_Play();
    }
    private void Awake() 
    {
        sourse = gameObject.GetComponent<AudioSource>();
        StartCoroutine(playAudio());
    }
    public void Audio_Play()
    {
        StartCoroutine(playAudio());
    }
    public void Audio_Stop()
    {
        sourse.Stop();
    }
    private void Update() 
    {
        sourse.volume = voluem_Music.value;
    }
}
