using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class score : MonoBehaviour
{
    public TextMeshProUGUI score_Text;
    public TextMeshProUGUI record_Score_Text;
    [SerializeField]
    private score_manager score_Manager;
    [SerializeField]
    private save_load_data save_Load_Data;
    private bool is_Paused;
    private void Awake() 
    {
        save_Load_Data.Load();
    }
    public int Add_Score()
    {
      return score_Manager.current_Account++;
    }
    public int Record_Score_Table()
    {
        return score_Manager.record_Score=score_Manager.current_Account;
    }
    
    private void FixedUpdate() 
    {  
        if(score_Manager.record_Score<score_Manager.current_Account)
        {
            save_Load_Data.Save_Record();
            Record_Score_Table();
        }
        record_Score_Text.text="Record: "+score_Manager.record_Score;
        score_Text.text="Score: "+score_Manager.current_Account;    
    }
}
