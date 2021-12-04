using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayerInput
{
    [CreateAssetMenu(menuName = "KindaGTA/UserInput/PlayerInputData")]
    public class PlayerInputData : ScriptableObject
    {
        public float Horizontal;
        public float Vertical;
        public string HorizontalAxis;
        public string VerticalAxis;
        public float HorizontalSpeed;
        public float VerticalSpeed;

        public void ProcessInput()
        {
            Horizontal = Input.GetAxis(HorizontalAxis);
            Vertical = Input.GetAxis(VerticalAxis);
        }
    }
}
