using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;
	public GameObject completeLevelUI;


    public void CompleteLevel ()
	{
		completeLevelUI.SetActive(true);
	}

	public void EndGame ()
	{
		if (gameHasEnded == false)
		{
			gameHasEnded = true;
			Debug.Log("GAME OVER");
			Invoke("Restart", 2);
		}
	}

	void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))  
        {
            SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene().name);
            SceneManager.LoadScene("Menu 3D", LoadSceneMode.Additive);
        }
    }
      
}
