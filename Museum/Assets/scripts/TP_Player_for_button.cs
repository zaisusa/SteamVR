using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP_Player_for_button : MonoBehaviour
{
    public GameObject go;
    Vector3 vec = new Vector3(0.5f, 1.2f, 2.3f);
    float i = 1.0f;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void spawn()
    {
        Instantiate(go, new Vector3(i * 0.5f, 1.2f, 2.3f), Quaternion.identity);
    }
}
