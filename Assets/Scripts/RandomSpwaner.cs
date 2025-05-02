using UnityEngine;

public class RandomSpawner : MonoBehaviour
{
    public GameObject Tank;
    private float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime; // Add time passed since last frame

        if (timer >= 3f) // Check if 3 seconds have passed
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-10, 30), 0, 30);
            Quaternion spawnRotation = Quaternion.Euler(0, 180, 0);
            Instantiate(Tank, randomSpawnPosition, spawnRotation);

            timer = 0f; // Reset timer
        }
    }
}
