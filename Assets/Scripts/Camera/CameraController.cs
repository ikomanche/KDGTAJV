using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayerInput;

namespace CameraContoller
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] PlayerInputData _inputData;
        //[SerializeField] GameObject firstCamera;
        void Update()
        {
            if (_inputData.Vertical < 0)
            {
                transform.Rotate(0, _inputData.VerticalSpeed * Time.deltaTime * -1, 0);
                gameObject.SetActive(true);
                //firstCamera.SetActive(false);
            }
            else if (_inputData.Vertical > 0)
            {
                transform.Rotate(0, _inputData.VerticalSpeed * Time.deltaTime, 0);
                gameObject.SetActive(true);
                //firstCamera.SetActive(false);
            }
        }
    }
}