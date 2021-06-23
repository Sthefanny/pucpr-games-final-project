using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyController : MonoBehaviour
{
    public List<GameObject> enemies;
    public float secondsToShowEnemy = 3;
    GameObject lastShown;
    bool isFirst = true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(generateRandomEnemy());
    }

    IEnumerator generateRandomEnemy()
    {
        while (true)
        {
            var seconds = isFirst ? 0 : secondsToShowEnemy;
            yield return new WaitForSeconds(seconds);
            isFirst = false;

            var enemyToShow = getEnemyToShow();
            lastShown = enemyToShow;
            Instantiate(enemyToShow, transform.position, transform.rotation, transform);
        }
    }

    GameObject getEnemyToShow() {

        var enemyToShow = enemies[Random.Range(0, enemies.Count)];

        while (lastShown != null && lastShown == enemyToShow)
        {
            enemyToShow = enemies[Random.Range(0, enemies.Count)];
        }

        return enemyToShow;
    }
}
