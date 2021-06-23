using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
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
        }
    }
}
