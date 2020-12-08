using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] _template;
    [SerializeField] private Transform _spawnPoint;
    
    private void Update()
    {
        Instantiate(_template[Random.Range(0, 4)], _spawnPoint.position + new Vector3(Random.Range(-9, 9),10, Random.Range(-9, 9)), Quaternion.identity);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(collision.gameObject);
    }
}
