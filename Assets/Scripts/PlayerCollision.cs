using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public PlayerMovement movement;     
    public ParticleSystem effect;


	void OnCollisionEnter (Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false; 
            Destroy(gameObject);
            effect.transform.position = new Vector3(this.transform.position.x, this.transform.position.y + 3, this.transform.position.z);
            effect.Play();
            FindObjectOfType<GameManager>().EndGame();
		}
	}
}
