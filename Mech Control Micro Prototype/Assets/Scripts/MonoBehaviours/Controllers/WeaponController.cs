using Interfaces;
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
            if (Input.GetMouseButtonDown(0))
                GetComponent<IWeapon>().Fire();

            // Right click aims
            if (Input.GetMouseButtonDown(1))
            {
                mainCamera.SetActive(false);
                aimCamera.SetActive(true);
            }
            else if (Input.GetMouseButtonUp(1))
            {
                mainCamera.SetActive(true);
                aimCamera.SetActive(false);
            }
        }
    }
}