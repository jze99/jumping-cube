using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class option : MonoBehaviour
{
    
    [SerializeField]
    private GameObject menu_Optoin;
    [SerializeField]
    private save_load_data save_Load_Data;
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        menu_Optoin.SetActive(false);
    }
    public void Option_Menu()
    {
        menu_Optoin.SetActive(true);
        Time.timeScale=0;
    }
    public void Close_Options()
    {
        menu_Optoin.SetActive(false);
        Time.timeScale=1;
    }
    public void Exit_Play()
    {
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
