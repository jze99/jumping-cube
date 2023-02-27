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
      Debug.Log("save");
   }
   public void Load()
   {
      score_Manager.record_Score=PlayerPrefs.GetInt("save_score");
      Debug.Log("load");
   }
}
