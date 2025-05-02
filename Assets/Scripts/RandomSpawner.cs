using UnityEngine;

public class RandomSp : MonoBehaviour
{
    public GameObject Tank;
    private float timer = 0f;

    // Update is called once per frame
    void Update()
    {
            timer += Time.deltaTime;
            if(timer>= 5f){

            
            Vector3 randomSpawnPosition= new Vector3(Random.Range(-23,23),0,70);
            Quaternion rotation = Quaternion.Euler(0, 180, 0);
            Instantiate(Tank, randomSpawnPosition, rotation);
            timer =0f;
            }
    }
}
