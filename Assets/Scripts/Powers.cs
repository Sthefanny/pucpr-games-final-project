using UnityEngine;
using UnityEngine.UI;

public class Powers : MonoBehaviour
{
    public int destroyedObjective = 10;

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

        verifyObjectiveCounts();
    }

    void changeTextValue(string textField)
    {
        var field = GameObject.Find(textField);
        var fieldText = field.GetComponent<Text>();

        var count = int.Parse(fieldText.text);
        count++;

        fieldText.text = count.ToString();
    }

    void verifyObjectiveCounts()
    {
        var field = GameObject.Find("destroyedTreesText");
        var destroyedTrees = field.GetComponent<Text>();
        var destroyedTreesCount = int.Parse(destroyedTrees.text);

        var field2 = GameObject.Find("destroyedRocksText");
        var destroyedRocks = field2.GetComponent<Text>();
        var destroyedRocksCount = int.Parse(destroyedRocks.text);

        var field3 = GameObject.Find("destroyedHuntersText");
        var destroyedHunters = field3.GetComponent<Text>();
        var destroyedHuntersCount = int.Parse(destroyedHunters.text);


        if (destroyedTreesCount >= destroyedObjective && destroyedRocksCount >= destroyedObjective && destroyedHuntersCount >= destroyedObjective)
        {
            EndingHelper.isVictory = true;

            FindObjectOfType<SceneController>().ChangeScene("EndingScene");
        }
    }
}
