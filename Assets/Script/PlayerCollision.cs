using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Runcube runcube;
    //enabled คือ การทำงานของสคริป
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            runcube.enabled = false;
            FindObjectOfType<GameManager>().EndGame();

        }
    }
}
