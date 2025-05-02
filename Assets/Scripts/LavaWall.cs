using UnityEngine;

public class LavaWall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision){
       if (collision.gameObject.CompareTag("Enemy")){
       Destroy(collision.gameObject);
       }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
