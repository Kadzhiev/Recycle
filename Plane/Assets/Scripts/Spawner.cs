using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private int _period;
    private Rigidbody _rigidody;

    private float time;

    private void Start()
    {
        time = Time.time;
        _rigidody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        time += Time.deltaTime;

        if (time >= _period)
        {
            time = 0;
            Instantiate(_template, _spawnPoint.position, Quaternion.identity);
        }
        _rigidody.AddForce(Vector3.forward * 1);
    }
}
