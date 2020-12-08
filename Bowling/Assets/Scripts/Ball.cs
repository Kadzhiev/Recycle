using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
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
        _rigidody.AddForce(Vector3.forward * _speed);
    }
}
