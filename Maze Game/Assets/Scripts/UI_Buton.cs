using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Buton : MonoBehaviour
{
    public GameObject pause;

    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        hidePaused();
    }

    void Update()
	{
        //uses the escape button to pause and unpause the game
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                showPaused();
            }
            else if (Time.timeScale == 0)
            {
                hidePaused();
            }

        }
    }
		
		public void OnMouseClick(string SceneName)
	{
		Player.collected = 0;
		SceneManager.LoadScene(SceneName, mode: LoadSceneMode.Single); //Loads game when menu button is pressed  
	}

    public void ExitGame()
    {
        Application.Quit();
    }

    public void showPaused()
    {
            Time.timeScale = 0;
            pause.SetActive(true);
           Screen.lockCursor = false;
           Cursor.visible = true;
    }

    
    public void hidePaused()
    {
            Time.timeScale = 1;
            pause.SetActive(false);
        Screen.lockCursor = true;
        Cursor.visible = false;
    }
}
