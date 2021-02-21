using System;
using Interfaces;
using UnityEngine;

namespace MonoBehaviours.Rotation
{
    public class TransformRotation : MonoBehaviour, IRotateable
    {
        public float rotationSpeed = 3.0f;
        public Transform rotationTarget;
        private Transform _transform;

        public void Rotate(Vector3 rotation)
        {
            if (rotation != Vector3.zero)
                _transform.Rotate(rotation * (rotationSpeed * Time.deltaTime));
        }

        private void Start()
        {
            _transform = rotationTarget != null ? rotationTarget : transform;
        }
    }
}