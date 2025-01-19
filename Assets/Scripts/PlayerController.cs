using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    [SerializeField] private float jumpForce = 10;
    [SerializeField] private float gravityModifier;
    private bool isOnGround = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); 
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround) 
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
