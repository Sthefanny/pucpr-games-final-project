using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float speed = 0.5f;
    public Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = new Vector2(Time.deltaTime * speed, 0f);

        renderer.material.mainTextureOffset += offset;
    }
}
