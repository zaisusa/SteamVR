using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;


public class Olga_Talking : MonoBehaviour
{
    public GameObject Olga;
    private VideoPlayer video;
    // Start is called before the first frame update
    void Start()
    {
        video = Olga.GetComponent<VideoPlayer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Olga"))
        {
            video.Play();
        }
    }
}
