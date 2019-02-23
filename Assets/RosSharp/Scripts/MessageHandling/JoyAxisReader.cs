/*
© Siemens AG, 2017-2018
Author: Dr. Martin Bischoff (martin.bischoff@siemens.com)

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
<http://www.apache.org/licenses/LICENSE-2.0>.
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using UnityEngine;
using System;

namespace RosSharp.RosBridgeClient
{
    public class JoyAxisReader : MonoBehaviour
    {        
        //public string Name;
        public string me;

        ControllMove controllMove;

        private float mp;
        private float mr;
        private float my;

        //private ControllMove controllMove = new ControllMove();
        void Update()
        {
            controllMove = GetComponent<ControllMove>();

            mp = controllMove.HandPalmPitch;
            mr = controllMove.HandPalmRoll;
            my = controllMove.HandPalmYam;
        }

        public float Read()
        {
            // me = Input.GetAxis(Name);
            // Debug.Log(" float Num: " + me);
            //controllMove = new ControllMove();
            if (me.Equals("H"))
            {
                //if (my > 1.3f && my < 1.6f)
                //{

                    if (mp > 1f && mp < 2.6f)
                    {
                        mp = .3f;
                    }
                    else
                    {
                        mp = -.3f;
                    }
                    
                //}
                //else
                //{
                //    mp = 0f;
                //}


            }
            else if (me.Equals("V"))
            {
                if (mr > 2.4f && mr< 2.8f)
                {
                    mp = 0f;
                }
                else
                {
                    if (my > 1.5f && my < 3.5f)
                    {
                        mp = -0.1f;
                    }
                    else if (my <= 1.5f)
                    {
                        mp = 0.1f;
                    }
                }
            }

            return mp;


            /*
            else if (me.Equals('V'))
            {
                mp = 0.1f;
            }
            if (mp > 0f && mp < 3.5f)
            {
                mp = 0.2f;
                //return mp;
            }
            else if (mr > 0f && mr < 3f)
            {
                mp = -0.2f;
                //return mp;
            }
            else
            {
                //mp = 0.2f;
            }
            Debug.Log(" float mp: " + mp);
            */
            //if ((mr > 0f && mr < 3f) && (my > 0f && my < 3f)) { mr = 0.5f; } else { mr = -0.5f; }

            //if (mp > mr)
            //{
            //  Debug.Log(" float mp: " + mp);
            // return mp;
            //}
            //else
            //{
            //   Debug.Log(" float mr: " + mr);
            //  Debug.Log(" float my: " + my);
            //  return mr;
            //}

        }
    }
}
