using UnityEngine;

public class Powers : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        Destroy(this.gameObject, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "BotoPower" && collision.gameObject.tag == "TreeOnFire")
        {
            Destroy(collision.gameObject);
        }
        else if (gameObject.tag == "SaciPower" && collision.gameObject.tag == "Rocks")
        {
            Destroy(collision.gameObject);
        }
        else if (gameObject.tag == "CurupiraPower" && collision.gameObject.tag == "Hunter")
        {
            Destroy(collision.gameObject);
        }
    }
}
