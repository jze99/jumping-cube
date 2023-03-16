using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class start_play : MonoBehaviour
{
    [SerializeField]
    private score_manager score_Manager;
    private int Clear_Account()
    {
        score_Manager.current_Account=0;
        score_Manager.number_of_Grapes=0;
        score_Manager.number_of_Kiwis=0;
        score_Manager.number_of_Tangerines=0;
        return 0;
    }
    private void Start()
    {
        Clear_Account();
    }
}
