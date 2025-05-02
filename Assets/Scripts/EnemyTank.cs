using UnityEngine;

public class EnemyTank : MonoBehaviour
{
    public int health  = 3;

    private void OnCollisionEnter(Collision collision){

        if (collision.gameObject.CompareTag("Player")){

            TankMovement player = collision.gameObject.GetComponent<TankMovement>();
            if(player != null){
                player.TakenDamage(1);
                

            }
            

            Destroy(gameObject);
        }  
    }
    public float speed = 5f;
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void TakenDamage(int damage){
        health -= damage;
        if(health <=0){
            Destroy(gameObject);
            ScoreScript.scoreValue +=1;
        }

    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.Translate(Vector3.forward*Time.deltaTime*speed);
        
    }
}
