using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private float _speed;

    private List<Transform> _transforms;

    private int time = 0;
    private int timer = 120;

    private void Start()
    {
        _transforms = new List<Transform>();
    }
    private void Update()
    {
        if (time >= timer)
        {
            time = 0;
            Instantiate(_template, _spawnPoint.position + new Vector3(Random.Range(-9, 9), 10, 0), Quaternion.identity);
        }
        time++;

        foreach (Transform transform in _transforms)
            transform.position += Vector3.forward * _speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        _transforms.Add(collision.gameObject.GetComponent<Transform>());
    }
}
