using System;
using Interfaces;
using UnityEngine;

namespace MonoBehaviours.Controllers
{
    public class WeaponController : MonoBehaviour
    {
        public IWeapon ActiveWeapon;
        public GameObject mainCamera;
        public GameObject aimCamera;

        private void Start()
        {
            ActiveWeapon = GetComponent<IWeapon>();
        }

        private void Update()
        {
            // Left click fires
            if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
                ActiveWeapon.Fire();

            // Right click aims
            if (Input.GetMouseButtonDown(1) || Input.GetKeyDown(KeyCode.LeftShift))
            {
                mainCamera.SetActive(false);
                aimCamera.SetActive(true);
            }
            else if (Input.GetMouseButtonUp(1) || Input.GetKeyUp(KeyCode.LeftShift))
            {
                mainCamera.SetActive(true);
                aimCamera.SetActive(false);
            }
        }
    }
}