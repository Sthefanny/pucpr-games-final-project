using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody player;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        player = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            animator.SetTrigger("TakeDamage");
        }
    }
}
