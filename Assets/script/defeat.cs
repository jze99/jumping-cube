using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class defeat : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI counting_Fruits;
    [SerializeField]
    private GameObject reset_Button;
    [SerializeField]
    save_load_data save_Load_Data;
    [SerializeField]
    private score_manager score_Manager;
    [SerializeField]
    private List<GameObject> Fructs = new List<GameObject>();
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
    public void Clic_Reset()
    {
        SceneManager.LoadScene(1);
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag=="Player")
        {
           SceneManager.LoadScene(2);
        }
    }
}
