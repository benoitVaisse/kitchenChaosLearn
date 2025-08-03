using System;
using UnityEngine;

namespace KitchenChaosLearn.Assets.Scripts.Player
{
    public class PlayerAnimator : MonoBehaviour
    {
        [SerializeField]
        private Player _player;

        private Animator _animator;
        private void Awake()
        {
            _animator = GetComponent<Animator>();
            if (_player == null)
                throw new Exception("Player not present in Player Animator");

            _animator.SetBool(nameof(PlayerAnimatorParametersType.IsWalking), _player.IsWalking);
        }

        private void Update()
        {
            _animator.SetBool(nameof(PlayerAnimatorParametersType.IsWalking), _player.IsWalking);
        }
    }
}
