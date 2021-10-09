using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int lives = 3;
    public static bool playGame = true;
    public static float currentTime;
    public static float endTimeout = 3;
    public GameManager text;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playGame == false)
        {
           if(Time.time - currentTime > endTimeout)
           {
               playGame = true;
           }
        }
    }

    public static void stopGame()
    {
        if (lives == 0) 
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }
        lives--;
        playGame = false;
        currentTime = Time.time;
    }
}
