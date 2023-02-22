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
    private bool is_Paused;
    public void Add_Score()
    {
       score_Manager.current_Account++;
    }
    public void Record_Score_Table()
    {
        score_Manager.record_Score=score_Manager.current_Account;
    }
    
    private void FixedUpdate() 
    {  
        if(score_Manager.record_Score<score_Manager.current_Account)
        {
            Record_Score_Table();
        }
        record_Score_Text.text="Record: "+score_Manager.record_Score;
        score_Text.text="Score: "+score_Manager.current_Account;    
    }
}
