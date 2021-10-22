using UnityEngine;
using System.Collections.Generic;

namespace RoomateWheel
{

    public class Wheel : MonoBehaviour
    {

        [Header("Categories")]

        [SerializeField]
        private List<WheelCategory> wheelCategories;

        [Header("Visuals")]

        [SerializeField]
        private WheelCategoryVisuals visualPrefab;

        private void Start()
        {
            // TODO: Implementation
        }
    }    
}