using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class JoyAxisReader1 : MonoBehaviour
    {

        //public string Name;
        private float mp;

        ControllMove controllMove;


        //private ControllMove controllMove = new ControllMove();
        void Update()
        {
            controllMove = GetComponent<ControllMove>();

            mp = controllMove.HandPalmPitch;
            //Debug.Log(" float mt: " + mt);
        }

        public float Read()
        {
            // me = Input.GetAxis(Name);
            // Debug.Log(" float Num: " + me);
            //controllMove = new ControllMove();
           



            if (mp > 0f && mp < 3f) { mp = 0.5f; } else { mp = -0.5f; }
            Debug.Log(" float mt: " + mp);
            return mp;
        }
    }
}