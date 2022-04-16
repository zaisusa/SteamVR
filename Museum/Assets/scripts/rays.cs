using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;
using UnityEngine.Rendering.PostProcessing;

public class rays : MonoBehaviour
{

    public float distante;
    public GameObject gm;
    public GameObject gm1;
    public GameObject point;
    public LineRenderer lr;

    void Start()
    {
        
    }
    void Update()
    {
        RaycastHit hit;
        var rays = Physics.Raycast(gm.transform.position, gm.transform.forward, out hit, Mathf.Infinity);
        Debug.DrawRay(gm.transform.position, hit.point, Color.yellow);
        Vector3 endpos = transform.position + (transform.forward * Mathf.Infinity);
        if (hit.collider != null)
        {
            endpos = hit.point;
            Debug.Log("Hit " + hit.collider.gameObject.name+ hit. point);
            point.transform.position = endpos;
        }

    }
    
}
