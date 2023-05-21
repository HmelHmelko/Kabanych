using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClerkSpawn : MonoBehaviour
{
    [SerializeField] private GameObject[] clerksPrefabs;
    [SerializeField] private Vector3 spawnPosition;

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
        int getRandomIndex = Random.Range(0,clerksPrefabs.Length - 1);
        Instantiate(clerksPrefabs[getRandomIndex], spawnPosition, Quaternion.identity);
    }
}
