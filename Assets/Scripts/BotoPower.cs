using UnityEngine;

public class BotoPower : MonoBehaviour
{
    public GameObject prefabToInstantiate;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnPointerClick()
    {
        if (player.transform.childCount <= 0)
        {
            Instantiate(prefabToInstantiate, player.transform, true);
        }
    }
}
