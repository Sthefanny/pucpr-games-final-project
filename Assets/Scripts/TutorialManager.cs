using UnityEngine;
using System;

public class TutorialManager : MonoBehaviour
{
    public TutorialModel[] tutorialList;
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

    public void ChangeTo(string name)
    {

        TutorialModel t = Array.Find(tutorialList, canvas => canvas.name == name);
        if (t == null)
        {
            Debug.LogWarning("Tutorial: " + name + " not found!");
            return;
        }
        t.source.enabled = true;

        actualTutorial.enabled = false;

        actualTutorial = t;
    }
}
