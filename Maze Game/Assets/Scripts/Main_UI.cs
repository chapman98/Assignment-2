using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_UI : MonoBehaviour
{

    public TMPro.TextMeshProUGUI Score;
    public TMPro.TextMeshProUGUI Timer;
    public float time = 0;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "Gems: " + Player.collected + "/30";

        //from: https://answers.unity.com/questions/1174761/20-minute-countdown-timer.html
        time -= Time.deltaTime;
        string minutes = Mathf.Floor(time / 60).ToString("00");
        string seconds = (time % 60).ToString("00");
        Timer.text = "Time: " + minutes + ":" + seconds;

        if(time <= 0 || Player.collected == 30)
        {
			SceneManager.LoadScene("End", mode: LoadSceneMode.Single);
		}
	}

}
