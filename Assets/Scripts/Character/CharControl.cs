using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerInput;

namespace PlayerControl 
{
    public class CharControl : MonoBehaviour
    {
        [SerializeField] PlayerInputData _inputData;
        //[SerializeField] Rigidbody _rigidbody;
        [SerializeField] GameObject Player;
        [SerializeField] GameObject secondCamera;
        [SerializeField] GameObject mainCamera;


        void Update()
        {
            //_rigidbody.MovePosition(_rigidbody.position + (_rigidbody.transform.forward * _inputData.Vertical * _inputData.VerticalSpeed));
            transform.Translate(0, 0, _inputData.Vertical * _inputData.VerticalSpeed * Time.deltaTime);
            transform.Rotate(0, _inputData.Horizontal * _inputData.HorizontalSpeed * Time.deltaTime, 0, Space.Self);
            if (_inputData.Vertical != 0)
            {
                Player.GetComponent<Animation>().Play("Run");
                secondCamera.SetActive(false);
                mainCamera.SetActive(true);
            }
            else //if(_inputData.Horizontal != 0)
            {
                Player.GetComponent<Animation>().Play("Idle");
                //mainCamera.SetActive(true);
                //firstCamera.SetActive(false);
            }
        }
    }
}