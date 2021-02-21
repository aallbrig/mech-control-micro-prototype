using System;
using System.Collections;
using Interfaces;
using MonoBehaviours.Controllers;
using UnityEngine;

namespace MonoBehaviours.Weapons
{
    public class TestWeapon : MonoBehaviour, IWeapon
    {
        public GameObject fireEffect;
        public GameObject firePoint;
        public float fireWait = 1.0f;
        private MechAnimationController _mechAnimator;
        private bool _canFire = true;

        public void Fire()
        {
            if (!_canFire) return;

            Debug.Log("[Test Weapon] Pew pew pew");
            _mechAnimator.RecoilRight();
            Destroy(Instantiate(fireEffect, firePoint.transform), fireWait);

            StartCoroutine(CanFireAgain());
        }

        private IEnumerator CanFireAgain()
        {
            yield return new WaitForSeconds(fireWait);
            _canFire = true;
        }
        private void OnEnable()
        {
            _mechAnimator = GetComponent<MechAnimationController>();
        }
    }
}