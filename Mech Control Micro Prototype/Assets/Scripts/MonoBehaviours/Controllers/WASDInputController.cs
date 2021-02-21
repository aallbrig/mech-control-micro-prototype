using Interfaces;
using UnityEngine;

namespace MonoBehaviours.Controllers
{
    public class WASDInputController : MonoBehaviour
    {
        // WASD Input controller either works on self or a target
        [Tooltip("Optional target to apply WASD movement (default: self)")]
        public GameObject moveTarget;
        public GameObject rotateTarget;

        private IMoveable _moveController;
        private IRotateable _rotateController;

        private void Start()
        {
            _moveController = (moveTarget != null ? moveTarget : gameObject).GetComponent<IMoveable>();
            _rotateController = (rotateTarget != null ? rotateTarget : gameObject).GetComponent<IRotateable>();
        }

        private void Update()
        {
            if (_moveController == null)
            {
                Debug.LogError("[WASD Input] IMoveable interface must be implemented");
                return;
            }
            if (_rotateController == null)
            {
                Debug.LogError("[WASD Input] IRotateable interface must be implemented");
                return;
            }

            var direction = new Vector3(0, 0, Input.GetAxis("Vertical"));
            _moveController.Move(direction);
            var rotation = new Vector3(0, Input.GetAxis("Horizontal"), 0);
            _rotateController.Rotate(rotation);
        }
    }
}