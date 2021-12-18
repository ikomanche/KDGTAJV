using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

namespace Events
{
    public class EventManager : MonoBehaviour
    {
        public GameObject FirstIntro;
        public delegate void AnimAction();
        public static event AnimAction OnAnim;
        public delegate IEnumerator AnimActionEnumarator();
        public static event AnimAction OnAnimEnumerator;
        //[SerializeField]private GeneralStats _generalStats;

        void Update()
        {
            //if(FirstIntro.active)
            //{
            //    if (OnAnim != null)
            //    {
            //        OnAnim();                    
            //        OnAnim += SetAnimOn;
            //        OnAnim -= SetAnimOff;
            //    }
            //    if (OnAnimEnumerator != null)
            //    {
            //        OnAnimEnumerator();                    
            //    }
                
            //}
            //else
            //{
            //    OnAnim -= SetAnimOn;
            //    OnAnim += SetAnimOff;
            //}
        }  
        
        public static void SetAnimOn()
        {
            GeneralStats.isAnimOn = true;
        }
        public static void SetAnimOff()
        {
            GeneralStats.isAnimOn = false;
        }
        
    }
}