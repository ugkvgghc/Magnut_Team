using UnityEngine;

public class Testaddforce : MonoBehaviour
{
    public Rigidbody rb;
    public int speedx = 10;
    public string[] talknpc;
    public string[] playerE;
    public int pointnpc = 0;
    public int pointplayer = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Debug.Log("H");
    }

    // Update is called once per frame
    void Update()
    {
        
        

    }
    private void FixedUpdate()
    {
        rb.AddForce(Vector3.forward * 20f * Time.fixedDeltaTime, ForceMode.Impulse);
    }
}
