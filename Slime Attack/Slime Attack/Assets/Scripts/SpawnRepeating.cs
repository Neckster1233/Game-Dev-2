using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRepeating : MonoBehaviour
{
    [SerializeField] private GameObject prefab;
    [SerializeField] private float startDelay = .5f;
    [SerializeField] private float startInterval = .1f;
    [SerializeField] private Vector3 spawnPosition = Vector3.zero;
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", startDelay, startInterval);
    }

    // Update is called once per frame
    
        void spawn()
        {
            Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
}
