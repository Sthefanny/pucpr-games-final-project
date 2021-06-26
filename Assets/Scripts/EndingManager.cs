using UnityEngine;
using UnityEngine.UI;

public class EndingManager : MonoBehaviour
{
    void Start()
    {
        var field = GameObject.Find("messageTitle");
        var messageTitle = field.GetComponent<Text>();

        var field2 = GameObject.Find("messageText");
        var messageText = field2.GetComponent<Text>();

        if (EndingHelper.isVictory)
        {
            messageTitle.text = "Congratulations!";
            messageText.text = "With the help of the Legends of the Forest you prevented the forest from being consumed by fire and stones and even helped the animals by scaring away the hunters.\n\nForests and animals really need our help, and although we don't have the powers in real life, we can all help to preserve the forest and thereby improve the world!\n\nContinue the efforts!";
        }
        else
        {
            messageTitle.text = "Oh no...";
            messageText.text = "Unfortunately Iara was too tired to continue helping to save the forest. But don't give up, every help is very important!\n\nForests and animals really need our help, and although we don't have the powers in real life, we can all help to preserve the forest and thereby improve the world!\n\nContinue the efforts!";
        }
    }
}
