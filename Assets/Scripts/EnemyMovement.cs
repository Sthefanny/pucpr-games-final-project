using System.Collections;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 0.5f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * -Time.deltaTime, 0f, 0f);
    }
}
