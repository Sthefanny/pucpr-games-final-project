using UnityEngine;
using System;

public class TutorialManager : MonoBehaviour
{
    public TutorialModel[] tutorialList;
    public float delaySeconds = 0.5f;
    TutorialModel actualTutorial;

    void Awake()
    {
        foreach (TutorialModel t in tutorialList)
        {
            t.source = t.canvas;
            t.source.enabled = t.enabled;
        }

        actualTutorial = tutorialList[0];
    }

    public void ChangeToNext()
    {
        var actualName = actualTutorial.name;
        var next = int.Parse(actualName) + 1;

        if(next == 10)
        {
            FindObjectOfType<SceneController>().ChangeScene("GameScene");
            return;
        }

        TutorialModel t = Array.Find(tutorialList, canvas => canvas.name == next.ToString());
        if (t == null)
        {
            Debug.LogWarning("Tutorial: " + actualName + " not found!");
            return;
        }
        t.source.enabled = true;

        actualTutorial.enabled = false;

        actualTutorial = t;
    }

    public void ChangeToGame()
    {
        FindObjectOfType<SceneController>().ChangeScene("GameScene");
    }
}
