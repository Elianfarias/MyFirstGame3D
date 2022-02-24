using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float maxTimer = 30f;
    private float countdown = 0f;

    private void Start()
    {
        countdown = maxTimer;
    }
    void Update()
    {
        if (countdown <= 0)
        {
            Debug.Log("Te has quedado sin tiempo.");
            CollectiveObject.objectCount = 0;
            SceneManager.LoadScene("MainScene");
        }
        else
        {
            countdown -= Time.deltaTime;
            Debug.Log("Tiempo restante: " + countdown);
        }


    }
}
