using UnityEngine;

namespace Scripts.Day3
{
    public class CubeGenerator : MonoBehaviour
    {
        [SerializeField] private GameObject cubePrefab;

        private void Awake()
        {
            GenerateCubeCircle(6, 3);
            GenerateCubeCircle(12, 6);
        }

        private void GenerateCubeCircle(int cubeCount, float radius)
        {
            for (int i = 0; i < cubeCount; i++)
            {
                float t = (float) i / cubeCount;
                float angle = (Mathf.PI * 2) * t;
                
                Vector3 pos = new Vector3(Mathf.Cos(angle), .5f, Mathf.Sin(angle)) * radius;
                var go = Instantiate(cubePrefab, pos, Quaternion.identity, transform);
                go.transform.LookAt(transform);
            }
        }
    }
}
