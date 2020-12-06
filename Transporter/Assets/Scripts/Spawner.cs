using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Stuff _template;
    [SerializeField] private Transform _spawnPoint;

    private int time = 0;
    private int timer = 120;

    private List<Stuff> stuffs;

    private void Start()
    {
        stuffs = new List<Stuff>();
        
    }
    private void Update()
    {
        if (time >= timer)
        {
            time = 0;
            stuffs.Add(Instantiate(_template, _spawnPoint.position + new Vector3(Random.Range(-9, 9), 0, 0), Quaternion.identity));
        }
        time++;

        foreach(Stuff s in stuffs)
            if (s.IsColliding)
            {
                s.Speed = 2f;
            }
    }
}
