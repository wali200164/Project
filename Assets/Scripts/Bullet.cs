using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;
    private bool hasHit = false;


    void Awake(){
        Destroy(gameObject, life);
    }
    private void OnCollisionEnter(Collision other) {
        if (hasHit) return;
        hasHit = true;

        if (other.gameObject.CompareTag("Enemy")){

            EnemyTank enemy = other.gameObject.GetComponent<EnemyTank>();
            if(enemy != null){
                enemy.TakenDamage(1);

            }
            

            Destroy(gameObject);
        }

    }
}
