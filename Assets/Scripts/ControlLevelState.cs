using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlLevelState : MonoBehaviour
{

    /*This class give me the possibility
     * to control if the next leve is just
     * completed or not. it must be implemented
     * when the gamer click on the "next btn"
     * of the win panel.
     */

    public int scene;
    public string level;

    public void controlState()
    {
        if (LevelManager.isDoneTheLevel(level))
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(1); // it loads the evelSelector scene
        }
        else
        {
            //In this way I'm sure the gameplay don't stop it at the beginning of the next level
            Time.timeScale = 1; 
            SceneManager.LoadScene(scene);

        }
    }


}
