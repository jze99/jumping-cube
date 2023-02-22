using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    private float[] spawn_Point={-3.5f,-1.5f,0,1.5f,3.5f};
    [SerializeField]
    private GameObject[] prefab_Platform;
    private static platform_controler controller;
    private static score score;
    private bool active_Platform=false;
    private int random_Position;
    private void Awake() 
    {
        controller = Camera.main.GetComponent<platform_controler>();
        score=GameObject.Find("Canvas").GetComponent<score>();
        transform.name="platform";
    }
    private void Random_Platform_position()
    {
        random_Position = Random.Range(0,4);
        if(transform.position.x==-3.5f&&random_Position==0)
        {
                random_Position++;
        } 
        else if(transform.position.x==-1.5f&&random_Position==1)
        {
            int ran = Random.Range(0,1);
            if(ran==1)
                random_Position++;
            else if(ran==0)
                random_Position--;
        }
        else if(transform.position.x==0&&random_Position==2)
        {
            int ran = Random.Range(0,1);
            if(ran==1)
                random_Position++;
            else if(ran==0)
                random_Position--;
        }
        else if(transform.position.x==1.5f&&random_Position==3)
        {
            int ran = Random.Range(0,1);
            if(ran==1)
                random_Position++;
            else if(ran==0)
                random_Position--;
        }
        else if(transform.position.x==3.5f&&random_Position==4)
        {
                random_Position--;
        }
    }
    private int Instantiate_Platform_Random()
    {
        if(random_Position==0||random_Position==4)
            return 0;
        else
            return Random.Range(0,prefab_Platform.Length);
            
    }
    
    private void OnCollisionEnter(Collision other)
     {
        if(other.collider.tag=="Player"&&active_Platform==false)
        {
            Random_Platform_position();
            Instantiate(prefab_Platform[Instantiate_Platform_Random()],new Vector3(spawn_Point[random_Position],gameObject.transform.position.y+2,0),Quaternion.identity);
            controller.platforms.Add(this.gameObject);
            score.Add_Score();
            active_Platform=true;
        }
    }
}
