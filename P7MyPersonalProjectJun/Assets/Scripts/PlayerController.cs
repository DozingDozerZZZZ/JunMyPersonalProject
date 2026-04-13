using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 10f;
    public float gravityModifer;
    public bool isOnGround = true;
    public bool gameOver = false;

    public bool doubleJumpUsed = false;
    public float doubleJumpForce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifer;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {  
            playerRb.AddForce(Vector3.up *jumpForce,ForceMode.Impulse);
            isOnGround = false;
            doubleJumpUsed = false;
        }
        else if(Input.GetKeyDown(KeyCode.Space) && !isOnGround && !doubleJumpUsed)
            {
            doubleJumpUsed = true;
            playerRb.AddForce(Vector3.up * doubleJumpForce, ForceMode.Impulse);
            Debug.Log("Player double jumped");
           
        }

    }
}
