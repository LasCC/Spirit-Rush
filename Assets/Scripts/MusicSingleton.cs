using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicSingleton : MonoBehaviour
{
    private static MusicSingleton instance;

    private void Awake()
    {

        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }
}