using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stats
{
    [CreateAssetMenu(menuName = "KindaGTA/Stats")]
    public class GeneralStats : ScriptableObject
    {
        public GameObject[] CameraArray;
        public static bool isAnimOn;
    }
    
}