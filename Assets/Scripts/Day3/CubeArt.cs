using System.Collections;
using UnityEngine;

namespace Scripts.Day3
{
    public class CubeArt : MonoBehaviour
    {
        [SerializeField] private Material[] materials;
        
        private Renderer[] renderers;

        private void Start()
        {
            GetRenderers();
            StartCoroutine(ChangeMaterials());
        }

        private void GetRenderers()
        {
            renderers = new Renderer[transform.childCount];

            for (int i = 0; i < renderers.Length; i++)
                renderers[i] = transform.GetChild(i).GetComponent<Renderer>();
        }

        private IEnumerator ChangeMaterials()
        {
            int index = 0;
            while (true)
            {
                renderers[index].material = GetRandomMaterial();
                
                index++;
                if (index == renderers.Length)
                    index = 0;
                
                yield return new WaitForSeconds(.1f);
            }
        }

        private Material GetRandomMaterial() => 
            materials[Random.Range(0, materials.Length)];
    }
}