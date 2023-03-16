using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class music : MonoBehaviour
{
    public List<AudioClip> musucs = new List<AudioClip>();
    public AudioSource source;
    private GameObject sourece_Cub;
    public Slider volium_Music;
    public Slider volium_Cub; 

    [SerializeField]
    private GameObject cube_Jump;
    private Transform cude;
    [SerializeField]
    private save_load_data save_Load_Data;
    IEnumerator playAudio()
    {
        source.clip = musucs[Random.Range(0,musucs.Count)];
        source.Play();
        yield return new WaitForSeconds(source.clip.length);
        Audio_Play();
    }
    private void Start() 
    {
        source = gameObject.GetComponent<AudioSource>();
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
        source.Stop();
    }
    public void Save_Sound_Music()
    {
        source.volume = volium_Music.value;
        save_Load_Data.Save_Valium_Music(volium_Music.value);
    }
    public void Save_Sound_Cub()
    {
        save_Load_Data.Save_Valium_Cub(volium_Cub.value);
    }
    public void cube_Jumping()
    {
        Destroy(sourece_Cub);
        sourece_Cub = Instantiate(cube_Jump,transform.position,Quaternion.identity);
        sourece_Cub.GetComponent<AudioSource>().volume=volium_Cub.value;
    }
}
