using UnityEngine;
using System.Collections;

public class Breaker : MonoBehaviour {
    public void shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }

    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Rigidbody>().isKinematic = true;
    }

    // Use this for initialization
    void Start () {
        //shoot(new Vector3(0, 0, 2000));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
