using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube_Collider : MonoBehaviour
{
    public GameObject cube;
    private Rigidbody rb;
    public float thrustx = 0.0f;
    public float thrustz = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = cube.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider col)
    {
        cube.SetActive(true);
        if (col.gameObject.tag == "Player")
        {
            rb.AddForce(thrustx, 0, thrustz, ForceMode.Impulse);
            Destroy(this.gameObject);
        }
    }
}
