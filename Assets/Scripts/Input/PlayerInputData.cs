using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Stats;

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
            if (!GeneralStats.isAnimOn)
            { 
                Horizontal = Input.GetAxis(HorizontalAxis);
                Vertical = Input.GetAxis(VerticalAxis);
            }
        }
    }
}
