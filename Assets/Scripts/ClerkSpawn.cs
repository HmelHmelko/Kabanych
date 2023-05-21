using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClerkSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] clerksPrefabs;
    [SerializeField] private Vector3 spawnPosition;

    private bool spawnDetected;
    public bool IsSpawned { get { return spawnDetected; } private set { spawnDetected = value; } }

    public Action onEnemySpawned;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateClerk()
    {
        onEnemySpawned?.Invoke();
        spawnDetected = true;
        int getRandomIndex = UnityEngine.Random.Range(0,clerksPrefabs.Length - 1);
        Instantiate(clerksPrefabs[getRandomIndex], spawnPosition, Quaternion.identity);
    }
}
