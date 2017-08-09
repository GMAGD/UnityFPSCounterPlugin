

using UnityEngine;

namespace Vollando.Plugins
{
    public class FPSBenchmark : MonoBehaviour
    {
        [SerializeField]
        GameObject prefab;

        void Update()
        {
            if (prefab)
                Instantiate(prefab, transform.position, Random.rotation, transform);
            else
                Debug.LogWarning("Prefab not set on FPSBenchmark!");
        }
    }
}