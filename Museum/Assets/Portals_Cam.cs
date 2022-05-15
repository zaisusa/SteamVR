using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portals_Cam : MonoBehaviour
{
    public Transform PlayerCam;
    public Transform Portal_cam;
    public Transform other_Portal;


    private void Update()
    {
        Vector3 playerOffset = PlayerCam.position - other_Portal.position;
        transform.position = Portal_cam.position - playerOffset;

        float Angulardiff = Quaternion.Angle(Portal_cam.rotation, other_Portal.rotation);

        Quaternion portalRot = Quaternion.AngleAxis(Angulardiff, Vector3.up);
        Vector3 newPosCam = Angulardiff * PlayerCam.forward;
        transform.rotation = Quaternion.LookRotation(newPosCam, Vector3.up);
    }
}
