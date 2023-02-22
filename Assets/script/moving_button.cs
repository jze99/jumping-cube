using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving_button : MonoBehaviour
{
    public bool clic_Left=false;
    public bool clic_Right=false;
    public int movement_Speed;
    public void Left_Down()
    {
        clic_Left=true;
    }
    public void Right_Down()
    {
        clic_Right=true;
    }
    public void Left_Up()
    {
        clic_Left=false;
    }
    public void Right_Up()
    {
        clic_Right=false;
    }
    private void moving_Player()
    {
        if(clic_Left)
        {
            gameObject.transform.position-=new Vector3(movement_Speed*Time.deltaTime,0,0);
        }
        if(clic_Right)
        {
            gameObject.transform.position+=new Vector3(movement_Speed*Time.deltaTime,0,0);
        }
    }
    private void Border(Vector3 positio_Player)
    {
        if(positio_Player.x<-4)
        {
            gameObject.transform.position=new Vector3(4f,positio_Player.y,0);
        }
        if(positio_Player.x>4)
        {
            gameObject.transform.position=new Vector3(-4f,positio_Player.y,0);
        }
    }
    private void Update() 
    {
        Border(gameObject.transform.position);
        moving_Player();
    }
}
