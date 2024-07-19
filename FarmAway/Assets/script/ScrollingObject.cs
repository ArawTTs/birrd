using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private SpriteRenderer spriteRender;
    public float speed = 1f;

    private void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        spriteRender.size = spriteRender.size + new Vector2(speed * Time.deltaTime, 0);
    }
}
