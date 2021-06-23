using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    void Start()
    {
        var destroyedTrees = GameObject.Find("destroyedTreesText");
        var destroyedTreesText = destroyedTrees.GetComponent<Text>();

        var destroyedRocks = GameObject.Find("destroyedRocksText");
        var destroyedRocksText = destroyedRocks.GetComponent<Text>();

        var destroyedHunters = GameObject.Find("destroyedHuntersText");
        var destroyedHuntersText = destroyedHunters.GetComponent<Text>();

        destroyedTreesText.text = "0";
        destroyedRocksText.text = "0";
        destroyedHuntersText.text = "0";
    }

    void Update()
    {
        
    }
}
