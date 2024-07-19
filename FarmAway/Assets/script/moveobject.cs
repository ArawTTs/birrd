using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveobject : MonoBehaviour
{
    [SerializeField] private float _speed = 0.5f;


    private void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime;
    }
}
