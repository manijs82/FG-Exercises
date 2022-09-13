using UnityEngine;

namespace Scripts.Day4
{
    public class DestroyOnImpact : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Bottom")) 
                Destroy(gameObject);
        }
    }
}