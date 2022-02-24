using UnityEngine;

public class CollectiveObject : MonoBehaviour
{
    public static int objectCount = 0;

    public void Start()
    {
        objectCount++;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            objectCount--;

            if (objectCount == 0)
            {
                GameObject gameManager = GameObject.Find("GameManager");
                Destroy(gameManager);
                GameObject[] fireworks = GameObject.FindGameObjectsWithTag("Fireworks");

                foreach (var firework in fireworks)
                {
                    firework.GetComponent<ParticleSystem>().Play();
                }
            }

            Destroy(gameObject);
        }
    }
}
