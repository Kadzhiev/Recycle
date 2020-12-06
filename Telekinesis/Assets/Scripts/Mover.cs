using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody _rigidody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rigidody.AddForce(Vector3.up * _speed);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            _rigidody.AddForce(Vector3.forward * _speed * 10);
        }
    }
}
