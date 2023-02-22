using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    private moving_button stoper;
    private Rigidbody rb_Player;
    [SerializeField]
    private static score_manager Score_Manager;
    public int jump_Power;
    private void Save_Game()
    {
        PlayerPrefs.SetInt("record",Score_Manager.record_Score);
    }
    private void Load_Game()
    {
        PlayerPrefs.GetInt("record");
    }
    private void Awake() 
    {
        rb_Player=gameObject.GetComponent<Rigidbody>();
        stoper = gameObject.GetComponent<moving_button>();

    }
    private void OnCollisionEnter(Collision other) 
    {
        if(other.collider.tag=="platform")
        {
            rb_Player.AddForce(0,1*jump_Power,0);
            if(stoper.clic_Left||stoper.clic_Right)
            {
                stoper.clic_Left=false;
                stoper.clic_Right=false;
            }
        }    
    }
    private void Update() 
    {
        if(rb_Player.velocity.y>=8)
            rb_Player.velocity=new Vector3(0,7,0);
    }
}
