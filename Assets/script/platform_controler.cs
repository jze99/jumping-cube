using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform_controler : MonoBehaviour
{
    public List<GameObject> platforms = new List<GameObject>();
    private void FixedUpdate() 
    {
        if(platforms.Count>5)
        {
            Destroy(platforms[0]);
            platforms.RemoveAt(0);
            platforms.RemoveAll (x => x == null);
        }    
    }
}
