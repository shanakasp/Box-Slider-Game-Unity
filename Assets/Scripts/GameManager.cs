using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;
    public float restartDelay = 5f;
   public void EndGame ()
    {
        if(gameHasEnded == false)
        {

            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
           
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
