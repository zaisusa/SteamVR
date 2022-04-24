using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Valve.VR.Extras
{
    public class SizeOfImage : MonoBehaviour
    {
        bool Scale = false;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void FixedUpdate()
        {



        }
        public void FixedSizeOfImage()
        {
            if (!Scale)
            {
                this.gameObject.transform.position += new Vector3(-0.2f, 0, 0);
                this.gameObject.transform.localScale += new Vector3(1, 1, 1);
                Scale = !Scale;
            } else
            {
                this.gameObject.transform.position += new Vector3(0.2f, 0, 0);
                this.gameObject.transform.localScale += new Vector3(-1, -1, -1);
                Scale = !Scale;
            }
            


        }
    }
}
