using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RoomateWheel
{
    [CreateAssetMenu(fileName = "Wheel Category", menuName = "RoomateWheel/Wheel Category")]
    public class WheelCategory : ScriptableObject
    {
        [SerializeField]
        private new string name;
        [SerializeField, TextArea(3, 10)]
        private string description;

        public string Name => name;

        public string Description => description;
    }
}
