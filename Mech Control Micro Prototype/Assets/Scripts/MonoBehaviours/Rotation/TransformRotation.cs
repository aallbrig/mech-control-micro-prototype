using System;
using Interfaces;
using UnityEngine;

namespace MonoBehaviours.Rotation
{
    public class TransformRotation : MonoBehaviour, IRotateable
    {
        public float rotationSpeed = 3.0f;
        private Transform _transform;

        public void Rotate(Vector3 rotation)
        {
            _transform.Rotate(rotation * (rotationSpeed * Time.deltaTime));
        }

        private void Start()
        {
            _transform = transform;
        }
    }
}