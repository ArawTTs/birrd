using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmanager : MonoBehaviour
{
    [SerializeField] private float _maxTime = 1.0f;
    [SerializeField] private float _heightRange = 1.0f;
    [SerializeField] private GameObject _obst;

    private float _timer;

    void Start()
    {
        spawnObst();
    }

    void Update()
    {
        if (_timer > _maxTime)
        {
            spawnObst();
            _timer = 0.0f;
        }

        _timer += Time.deltaTime;
    }

    void spawnObst()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(0, (int)_heightRange),0);
        GameObject obst = Instantiate(_obst, spawnPos, Quaternion.identity);

        obst.tag = "Obstacle";
        Destroy(obst, 10f);
    }
}
