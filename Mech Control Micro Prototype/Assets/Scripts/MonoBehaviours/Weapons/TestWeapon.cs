using Interfaces;
using UnityEngine;

namespace MonoBehaviours.Weapons
{
    public class TestWeapon : MonoBehaviour, IWeapon
    {
        public void Fire()
        {
            Debug.Log("[Test Weapon] Pew pew pew");
        }
    }
}