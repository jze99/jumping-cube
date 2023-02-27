using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class defeat : MonoBehaviour
{
    [SerializeField]
    private GameObject reset_Button;
    [SerializeField]
    save_load_data save_Load_Data;
    [SerializeField]
    private score_manager score_Manager;
    private void Awake() 
    {
        reset_Button=transform.parent.GetChild(1).GetChild(2).gameObject;
        reset_Button.SetActive(false);
        score_Manager.current_Account=0;
        Time.timeScale=1;
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
        }
    }
}
