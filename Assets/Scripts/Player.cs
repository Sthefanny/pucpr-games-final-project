using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 3;
    public int currentHealth;

    public HealthBar healthBar;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TreeOnFire" || collision.gameObject.tag == "Hunter" || collision.gameObject.tag == "Rocks")
        {
            Destroy(collision.gameObject);
            animator.SetTrigger("TakeDamage");
            TakeDamage(1);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
