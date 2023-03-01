using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class save_load_data : MonoBehaviour
{
   [SerializeField]
   private score_manager score_Manager;
   public void Save_Record()
   {
      PlayerPrefs.SetInt("save_score",score_Manager.record_Score);
      PlayerPrefs.Save();
   }
   public float Save_Valium_Music(float _valium_Music)
   {
      score_Manager.valium_Music=_valium_Music;
      PlayerPrefs.SetFloat("save music",score_Manager.valium_Music);
      return 0;
   }
   public float Save_Valium_Cub(float _valium_Cub)
   {
      score_Manager.valium_Cub=_valium_Cub;
      PlayerPrefs.SetFloat("save cub",score_Manager.valium_Cub);
      return 0;
   }
   public void Load()
   {
      score_Manager.record_Score=PlayerPrefs.GetInt("save_score");
      Debug.Log("load");
   }
}
