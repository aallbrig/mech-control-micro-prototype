using System;
using UnityEngine;

namespace MonoBehaviours.Controllers
{
    public class WeaponController : MonoBehaviour
    {
        public GameObject mainCamera;
        public GameObject aimCamera;

        private void Update()
        {
            // Left click fires
            // Right click aims
            if (Input.GetMouseButtonDown(1))
            {
                mainCamera.SetActive(false);
                aimCamera.SetActive(true);
            } else if (Input.GetMouseButtonUp(1))
            {
                mainCamera.SetActive(true);
                aimCamera.SetActive(false);
            }
        }
    }
}