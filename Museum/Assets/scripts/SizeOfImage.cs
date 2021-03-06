using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Valve.VR.Extras
{
    public class SizeOfImage : MonoBehaviour
    {
        bool Scale = false;
        bool OnText = false;
        public TMP_Text tx;

        Mask mask;

        [SerializeField]  GameObject panel;
        [SerializeField] GameObject button;

        // Start is called before the first frame update
        void Start()
        {
            panel = transform.parent.gameObject;
            //panel = this.gameObject;
            button = transform.GetChild(0).gameObject;

            mask = panel.GetComponent<Mask>();
        }

        // Update is called once per frame
        void FixedUpdate()
        {



        }
        public void FixedSizeOfImage()
        {
            if (!Scale)
            {
               panel.transform.position += new Vector3(-0.2f, 0, 0);
                panel.transform.localScale += new Vector3(1, 1, 1);
                button.SetActive(true);
                mask.enabled = false;
            }
            else
            {
                panel.transform.position += new Vector3(0.2f, 0, 0);
                panel.transform.localScale += new Vector3(-1, -1, -1);
                button.SetActive(false);
                tx.enabled = false;
                mask.enabled = true;
            }
            Scale = !Scale;
        }
        public void OnEnabledText()
        {
            if (!OnText)
            {
                tx.enabled = true;
                OnText = true;
            }
            else
            {
                tx.enabled = false;
                OnText = false;

            }

        }
    }
}
