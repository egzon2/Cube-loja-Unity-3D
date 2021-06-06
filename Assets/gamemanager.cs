using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour {
    bool gameHasEnded = false;
    public float RestartDelay = 1f;

    public void GameOver()
    {
        if (gameHasEnded == false)
            gameHasEnded = true;
        Debug.Log("Game Over!");
        Invoke("Restart", RestartDelay);
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
