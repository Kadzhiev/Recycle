using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Stuff[] _template;
    [SerializeField] private Transform _spawnPoint;
    private bool _isFallnig;
    private Stuff _object = null;

    private void Start()
    {
        _isFallnig = false;
    }
    private void Update()
    {
        while(!_isFallnig)
        {
            _object = Instantiate(_template[Random.Range(0, 4)], _spawnPoint.position + new Vector3(Random.Range(-9, 9),0, Random.Range(-9, 9)), Quaternion.identity);
            _isFallnig = true;
        }
        
        if (_object && _object.IsColliding)
        {
            GameObject.Destroy(_object.gameObject);
            _isFallnig = false;
        }
        if (_object && _object.IsOnFloor)
        {
            _isFallnig = false;
        }
    }
}
