using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class guid : MonoBehaviour
{
    //audio
    AudioSource guid_text;
    public AudioClip ac_f;
    public AudioClip ac_s;
    public AudioClip ac_t;
    List<AudioClip> sounds = new List<AudioClip>();
    int _audio;

    
    //buttons
    public Canvas cn;
    public GameObject go;
    public GameObject Strt;
    public GameObject Next;
    public TMP_Text tx;
    int t = 0;
    bool k = true;
    List<string> frazi = new List<string>() 
    {
        "Начало теста гида бла-бла-бла",
        "Текст гида бла-бла-бла",
        "Ещё тескт гида бла-бла-бла",
        "Конец текст гида бла-бла-бла"
    };

    private void Awake()
    {
        sounds.Add(ac_f);
        sounds.Add(ac_s);
        sounds.Add(ac_t);
    }

    void Start()
    {
        guid_text = gameObject.GetComponent<AudioSource>();
        tx.text = frazi[t];
        t++;
    }

    void Update()
    {
        
    }
    public void next()
    {
        tx.text = frazi[t];
        t++;
        if (t > frazi.Count - 1)
        {
            Next.SetActive(false);
        }
        if (_audio < frazi.Count)
        {
            guid_text.clip = sounds[_audio];
            guid_text.Play();
            _audio++;
        }
    }
    public void text()
    {
        go.SetActive(true);
        Strt.SetActive(false);
        Next.SetActive(true);
        guid_text.clip = sounds[_audio];
        guid_text.Play();
        _audio++;
    }

}
