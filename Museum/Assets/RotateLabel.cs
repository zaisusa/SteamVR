using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateLabel : MonoBehaviour
{
    [SerializeField]
    private float speed;


    private void FixedUpdate()
    {
        this.transform.Rotate(new Vector3(0, 1, 0), speed);
    }
}
