using UnityEngine;

public class PowerActivate : MonoBehaviour
{
    public GameObject powerToInstantiate;
    public GameObject powerPoint;
    public string audioName;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnClick()
    {
        if (powerPoint.transform.childCount <= 0)
        {
            Instantiate(powerToInstantiate, powerPoint.transform, true);


            FindObjectOfType<AudioManager>().Play(audioName);
        }
    }
}
