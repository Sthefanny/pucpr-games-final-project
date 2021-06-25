using UnityEngine;
using UnityEngine.UI;

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
            changeTextValue("destroyedTreesText");
        }
        else if (gameObject.tag == "SaciPower" && collision.gameObject.tag == "Rocks")
        {
            Destroy(collision.gameObject);
            changeTextValue("destroyedRocksText");
        }
        else if (gameObject.tag == "CurupiraPower" && collision.gameObject.tag == "Hunter")
        {
            Destroy(collision.gameObject);
            FindObjectOfType<AudioManager>().Play("EnemyHurt");
            changeTextValue("destroyedHuntersText");
        }
    }

    void changeTextValue(string textField)
    {
        var field = GameObject.Find(textField);
        var fieldText = field.GetComponent<Text>();

        var count = int.Parse(fieldText.text);
        count++;

        fieldText.text = count.ToString();
    }
}
