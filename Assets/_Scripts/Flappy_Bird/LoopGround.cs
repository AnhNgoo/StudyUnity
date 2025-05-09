using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float Speed = 1f;
    [SerializeField] private float with = 6f;

    private SpriteRenderer spriteRenderer;
    private Vector2 startSize;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        startSize = new Vector2(spriteRenderer.size.x, spriteRenderer.size.y);
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.size = new Vector2(spriteRenderer.size.x + Speed * Time.deltaTime, spriteRenderer.size.y);

        if(spriteRenderer.size.x > with)
        {
            spriteRenderer.size = startSize;
        }
    }
}
