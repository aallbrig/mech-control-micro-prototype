using System;
using Interfaces;
using MonoBehaviours.Controllers;
using UnityEngine;

namespace MonoBehaviours.Weapons
{
    public class TestWeapon : MonoBehaviour, IWeapon
    {
        private MechAnimationController _mechAnimator;

        public void Fire()
        {
            _mechAnimator.RecoilRight();
            Debug.Log("[Test Weapon] Pew pew pew");
        }

        private void OnEnable()
        {
            _mechAnimator = GetComponent<MechAnimationController>();
        }
    }
}