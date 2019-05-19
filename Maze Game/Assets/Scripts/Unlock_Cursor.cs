using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlock_Cursor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
		Screen.lockCursor = false;
		Cursor.visible = true;
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
