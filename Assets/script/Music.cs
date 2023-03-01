using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music : MonoBehaviour
{
    public List<AudioClip> musucs = new List<AudioClip>();
    private AudioSource sourse;
    public Slider volium_Music;
    public Slider volium_Cub; 
    public GameObject sound;
    [SerializeField]
    private GameObject cube_Jump;
    private Transform cude;
    [SerializeField]
    private save_load_data save_Load_Data;
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
        volium_Music.value=PlayerPrefs.GetFloat("save music");
        volium_Cub.value=PlayerPrefs.GetFloat("save cub");     
    }
    public void Audio_Play()
    {
        StartCoroutine(playAudio());
    }
    public void Audio_Stop()
    {
        sourse.Stop();
    }
    public void Save_Sound_Music()
    {
        sourse.volume = volium_Music.value;
        save_Load_Data.Save_Valium_Music(volium_Music.value);
    }
    public void Save_Sound_Cub()
    {
        save_Load_Data.Save_Valium_Cub(volium_Cub.value);
    }
    public void cube_Jumping()
    {
        Destroy(sound);
        sound = Instantiate(cube_Jump,transform.position,Quaternion.identity);
        sound.GetComponent<AudioSource>().volume=volium_Cub.value;
    }
}
