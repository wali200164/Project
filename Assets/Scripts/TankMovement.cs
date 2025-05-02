using UnityEngine;
using UnityEngine.UI;
public class TankMovement : MonoBehaviour
{
    public float speed = 10;
    private float horizontalInput;
    public int maxHealth = 3;
    private float currentHealth;
    [SerializeField] private HealthBar _healthbar;

    public GameOver GameOver;
    public void gameOver(){
        GameOver.Setup(maxHealth);
    }

    void Start()
    {
        currentHealth = maxHealth;
        _healthbar.UpdateHealthBar(maxHealth, currentHealth);
    }

    public void TakenDamage(int damage)
    {
        currentHealth -= damage;
        _healthbar.UpdateHealthBar(maxHealth, currentHealth);

        if (currentHealth <= 0)
        {
             gameOver();
            Destroy(_healthbar.gameObject);
            Destroy(gameObject);
        }
    }

    void LateUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
    }
}
