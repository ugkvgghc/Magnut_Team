using UnityEngine;

public class Runcube : MonoBehaviour
{
    public int speed = 100;
    public int speedforward = 1000;
    public Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, 0);
        rb.AddForce(0, 0,speedforward * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-speed * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(speed * Time.deltaTime,0,0,ForceMode.VelocityChange);
        }

        else if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame(); //À“object∑’Ë¡’ §√‘ªGameManager ·≈–‡√’¬°„™È§” —ËßEndGame
        }
        
        
    }

}
