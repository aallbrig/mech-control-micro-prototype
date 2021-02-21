using Interfaces;
using UnityEngine;

namespace MonoBehaviours.Movement
{
    public class TransformMovement : MonoBehaviour, IMoveable, IVelocity
    {
        public float speed = 1.0f;
        public Transform directionTransform;

        private Transform _transform;

        private void Start()
        {
            _transform = GetComponent<Transform>();
        }

        public void Move(Vector3 direction)
        {
            Velocity = direction.normalized.magnitude;

            if (direction == Vector3.zero) return;

            if (directionTransform != null)
            {
                _transform.Translate(direction * (speed * Time.deltaTime), directionTransform);
                _transform.rotation = Quaternion.Euler(0, directionTransform.rotation.eulerAngles.y, 0);
                directionTransform.localEulerAngles = new Vector3(0, 0, 0);
            }
            else
                _transform.Translate(direction * (speed * Time.deltaTime));
        }

        public float Velocity { get; private set; }
    }
}