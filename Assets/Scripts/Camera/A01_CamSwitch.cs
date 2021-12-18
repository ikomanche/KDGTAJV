using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerInput;
using Events;
using System;

namespace CameraContoller
{    
    public class A01_CamSwitch : MonoBehaviour
    {
        [SerializeField] private GameObject firstCam;
        [SerializeField] private GameObject secondCam;        
        [SerializeField] private GameObject creds;        

        void Start()
        {            
            StartCoroutine(CamSwitcher());//scenemanager
        }

        IEnumerator CamSwitcher()
        {
            yield return new WaitForSeconds(7); //will be replaced by UI buttons
            secondCam.SetActive(true);
            firstCam.SetActive(false);            
            EventManager.SetAnimOn();
            Cursor.lockState = CursorLockMode.Locked;
            yield return new WaitForSeconds(7);
            creds.SetActive(false);
            EventManager.SetAnimOff();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = false;
        }

        //private void PlayAnim()
        //{
        //    Cursor.lockState = CursorLockMode.Locked;            
        //    Cursor.lockState = CursorLockMode.None;
        //}
    }
}