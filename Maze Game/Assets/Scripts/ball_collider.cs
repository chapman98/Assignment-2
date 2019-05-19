using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_collider : MonoBehaviour
{
    public GameObject balls;
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            balls.SetActive(true);
        }
    }
    }
