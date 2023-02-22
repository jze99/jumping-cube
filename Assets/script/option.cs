using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class option : MonoBehaviour
{
    [SerializeField]
    private GameObject menu_Optoin;
    
    private void Start() 
    {
        
    }
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
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
