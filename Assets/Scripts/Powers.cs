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
        print("O " + gameObject.tag + " encostou no " + collision.gameObject.tag);
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
            changeTextValue("destroyedHuntersText");
        }
    }

    void changeTextValue(string textField)
    {
        print("Vai alterar o textField");
        var field = GameObject.Find(textField);
        var fieldText = field.GetComponent<Text>();

        var count = int.Parse(fieldText.text);
        print("Count atual = " + count);
        count++;
        print("Count novo = " + count);

        fieldText.text = count.ToString();
    }
}
