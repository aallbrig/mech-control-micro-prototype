using Interfaces;
using UnityEngine;

namespace MonoBehaviours.Controllers
{
    public class MechAnimationController : MonoBehaviour
    {
        public GameObject animatorTarget;
        private Animator _animator;
        private IVelocity _velocity;

        private void Start()
        {
            _animator = animatorTarget.GetComponent<Animator>();
            _velocity = GetComponent<IVelocity>();
        }

        private void Update() => _animator.SetFloat("speed", _velocity.Velocity);
    }
}