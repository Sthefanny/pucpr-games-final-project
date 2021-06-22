using UnityEngine;

public class Powers : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TreeOnFire")
        {
            Destroy(collision.gameObject);
        }
    }
}
