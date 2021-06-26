using UnityEngine;

[System.Serializable]
public class TutorialModel
{
    public string name;

    public Canvas canvas;

    public bool enabled;

    [HideInInspector]
    public Canvas source;
}
