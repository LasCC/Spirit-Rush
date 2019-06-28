using UnityEngine;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour {
	public Rigidbody rb;

	public float forwardForce = 2000f;	
	public float sidewaysForce = 500f;  
    public float verticalForce = 100f;

    private CharacterController controller;
	private float verticalVelocity;
    private float gravity = 14.0f;
    private float jumpForce = 10.0f;


    void FixedUpdate ()
	{
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey(KeyCode.RightArrow))  
        {
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey(KeyCode.LeftArrow)) 
        {
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

        if (Input.GetKey(KeyCode.UpArrow))  
        {
            rb.AddForce(0, verticalForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.DownArrow)) 
        {
            rb.AddForce(0, -verticalForce * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(0, 0, -verticalForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f)
		{
			FindObjectOfType<GameManager>().EndGame();
		}

        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
            }
            else
            {
                verticalVelocity -= gravity * Time.deltaTime;
            }
            Vector3 moveVector = new Vector3(0, verticalVelocity, 0);
            controller.Move(moveVector * Time.deltaTime);
        }
    }
}
