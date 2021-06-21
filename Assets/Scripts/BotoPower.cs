using UnityEngine;
using UnityEngine.EventSystems;

public class BotoPower : MonoBehaviour, IPointerClickHandler
{
    public GameObject prefabToInstantiate;
    Transform powerPoint;

    // Start is called before the first frame update
    void Start()
    {
        powerPoint = transform.GetChild(0);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Instantiate(prefabToInstantiate, powerPoint.position, powerPoint.rotation);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "TreeOnFire")
        {
            Destroy(collision.gameObject);
        }
    }
}
