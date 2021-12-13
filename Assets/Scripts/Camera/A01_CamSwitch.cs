using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerInput;

namespace CameraContoller
{
    public class A01_CamSwitch : MonoBehaviour
    {
        [SerializeField] private GameObject firstCam;
        [SerializeField] private GameObject secondCam;        

        void Start()
        {            
            StartCoroutine(CamSwitcher());
        }

        IEnumerator CamSwitcher()
        {
            yield return new WaitForSeconds(7);            
            secondCam.SetActive(true);
            firstCam.SetActive(false);
        }
    }
}