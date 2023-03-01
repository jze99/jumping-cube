using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class defeat : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI text_Fructs;//переимеовать
    private GameObject reset_Button;
    [SerializeField]
    save_load_data save_Load_Data;
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
    private void Awake() 
    {
        reset_Button=transform.parent.GetChild(1).GetChild(2).gameObject;
        reset_Button.SetActive(false);
        Time.timeScale=1;
    }
    private void Start()
    {
        Clear_Account();
    }
    public void Clic_Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag=="Player")
        {
            Time.timeScale=0;
            reset_Button.SetActive(true);
            text_Fructs.text="Tangerines "+score_Manager.number_of_Tangerines+" + Kiwis "+score_Manager.number_of_Kiwis+" + Grapes "+score_Manager.number_of_Grapes;
            text_Fructs.gameObject.SetActive(true);
        }
    }
}
