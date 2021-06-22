using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    public GameObject prefabToShow;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(generateRandomEnemy());
    }

    IEnumerator generateRandomEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            Instantiate(prefabToShow, transform.position, transform.rotation, transform);
        }
    }
}
