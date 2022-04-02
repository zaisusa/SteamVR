using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class guid : MonoBehaviour
{
    AudioSource guid_text;
    //auidio
    public AudioClip ac;

    //buttons
    public Canvas cn;
    public GameObject go;
    public GameObject Strt;
    public GameObject Next;
    public TMP_Text tx;
    int t = 0;
    int k = 0;





    List<string> frazi = new List<string>() 
    {
        "Текст гида бла-бла-бла",
        "Конец текст гида бла-бла-бла"
    };
    void Start()
    {
        guid_text = gameObject.GetComponent<AudioSource>();
        tx.text = frazi[t];
        t++;
    }

    void Update()
    {
        if (k < 1)
        {
            sound();
        }
    }
    public void next()
    {
        tx.text = frazi[t];
        t++;
        if (t > frazi.Count - 1)
        {
            Next.SetActive(false);
        }
    }
    public void text()
    {
        go.SetActive(true);
        Strt.SetActive(false);
        Next.SetActive(true);
        
    }
    void sound()
    {
        guid_text.Play();
        k++;
    }
}
