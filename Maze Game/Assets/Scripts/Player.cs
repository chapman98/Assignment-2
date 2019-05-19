using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static int collected =0;
    public AudioSource collect;

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "gem")
        {
            collect.Play();
            Destroy(col.gameObject);
            collected++;
        }

    }
}
