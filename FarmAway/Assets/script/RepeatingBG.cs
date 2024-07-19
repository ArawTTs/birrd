using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float glength;

    void Start()
    {
        groundCollider = GetComponent<BoxCollider2D>();
        glength = groundCollider.size.x;
        Debug.Log(glength);
    }

    
    void Update()
    {
        if(transform.position.x < -glength)
        {
            RepositionBG();
        }
    }

    private void RepositionBG()
    {
        Vector2 groundOffset = new Vector2(glength * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
