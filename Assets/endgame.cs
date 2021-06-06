using UnityEngine;
using UnityEngine.SceneManagement;

public class endgame : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
