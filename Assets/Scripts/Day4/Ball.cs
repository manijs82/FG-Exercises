using UnityEngine;

namespace Scripts.Day4
{
    public class Ball : MonoBehaviour
    {
        private Rigidbody _rigidbody;
        
        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody>();
            AddForce(15);
        }

        private void AddForce(float force)
        {
            _rigidbody.AddForce(Vector3.forward * force, ForceMode.Impulse);
        }
    }
}