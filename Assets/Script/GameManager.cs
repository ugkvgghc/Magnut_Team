using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gamehasending = false;
    public float restartDelay = 2f;
    public GameObject completeUi;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void EndGame()
    {
        if (gamehasending == false)
        {
            gamehasending = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay); // √Õ‡«≈“·≈È«„™È§” —Ëßrestart
        }
        
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
    public void CompleteLevel()
    {
        Debug.Log("win");
        completeUi.SetActive(true);
    }
}
