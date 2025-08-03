using UnityEngine;

namespace KitchenChaosLearn.Assets.Scripts.Player
{
    public class Player : MonoBehaviour
    {
        [SerializeField]
        private int _moveSpeed = 7;
        [SerializeField]
        private float _speedRotation = 10f;

        public bool IsWalking { get; private set; }

        private void Update()
        {
            Vector2 inputManager = new();
            if (Input.GetKey(KeyCode.W))
            {
                inputManager.y += 1f;
            }
            if (Input.GetKey(KeyCode.S))
            {
                inputManager.y -= 1f;
            }
            if (Input.GetKey(KeyCode.A))
            {
                inputManager.x -= 1f;
            }
            if (Input.GetKey(KeyCode.D))
            {
                inputManager.x += 1f;
            }

            inputManager = inputManager.normalized;
            Vector3 moveDirection = new(inputManager.x, 0f, inputManager.y);
            IsWalking = moveDirection != Vector3.zero;
            transform.position += moveDirection * Time.deltaTime * _moveSpeed;
            transform.forward = Vector3.Slerp(transform.forward, moveDirection, Time.deltaTime * _speedRotation);
        }

    }
}
