using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using Valve.VR;

public class uiInteraction : BaseInputModule
{
    public Camera cam;
    public SteamVR_Input_Sources targSource;
    public SteamVR_Action_Boolean clcikAct;

    private GameObject curObj;
    private PointerEventData data;


    protected override void Awake()
    {
        base.Awake();
        data = new PointerEventData(eventSystem);
    }
    public override void Process()
    {
        data.Reset();
        data.position = new Vector2(cam.pixelWidth / 2, cam.pixelHeight / 2);

        eventSystem.RaycastAll(data, m_RaycastResultCache);
        data.pointerCurrentRaycast = FindFirstRaycast(m_RaycastResultCache);
        curObj = data.pointerCurrentRaycast.gameObject;

        m_RaycastResultCache.Clear();

        HandlePointerExitAndEnter(data, curObj);

        if (clcikAct.GetStateDown(targSource))
        {
            ProcessPress(data);
        }

        if (clcikAct.GetStateUp(targSource))
        {
            ProcessRelease(data);
        }

    }
    
    public PointerEventData GetData()
    {
        return data;
    }
    private void ProcessPress(PointerEventData data)
    {

    }

    private void ProcessRelease(PointerEventData data)
    {

    }
}
