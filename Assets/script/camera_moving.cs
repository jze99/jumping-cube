using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_moving : MonoBehaviour
{
    private Camera camera_Player;
    private void Camera_Behind_Player()
    {
        if(gameObject.transform.position.y>camera_Player.transform.position.y)
            camera_Player.transform.position=new Vector3(0,transform.position.y,-10);
    }
    private void Awake() 
    {
        camera_Player=Camera.main;
    }
    private void FixedUpdate() 
    {
            Camera_Behind_Player();
    }
}
