using UnityEngine;
using System.Collections;

public class BreakerGenerator : MonoBehaviour {

    public GameObject BreakerPrefab;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject Breaker = Instantiate(BreakerPrefab) as GameObject;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 worldDir = ray.direction;
            Breaker.GetComponent<Breaker>().shoot(worldDir.normalized * 10000);
        }
    }
}
