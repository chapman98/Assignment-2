using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Score : MonoBehaviour
{
    public TMPro.TextMeshProUGUI Score;
    // Start is called before the first frame update
    void Start()
    {
        Score.text = "Gems: " + Player.collected + "/30";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
