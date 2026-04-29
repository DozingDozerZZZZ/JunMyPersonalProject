using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 10f;
    public float gravityModifer;
    public bool gameOver = false;

   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifer;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !gameOver)
        {  
            playerRb.AddForce(Vector3.up *jumpForce,ForceMode.Impulse);
          
        }
       
    }
}
