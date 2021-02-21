using Interfaces;
using UnityEngine;

namespace MonoBehaviours.Controllers
{
    public class MechAnimationController : MonoBehaviour
    {
        [SerializeField] private GameObject animatorTarget;
        private Animator _animator;
        private IVelocity _velocity;

        public void RecoilLeft() => _animator.SetTrigger("recoil (left)");
        public void RecoilRight() => _animator.SetTrigger("recoil (right)");
        public void PunchLeft() => _animator.SetTrigger("punch (left)");
        public void PunchRight() => _animator.SetTrigger("punch (right)");

        private void Start()
        {
            _animator = animatorTarget.GetComponent<Animator>();
            _velocity = GetComponent<IVelocity>();
        }

        private void Update() => _animator.SetFloat("speed", _velocity.Velocity);
    }
}