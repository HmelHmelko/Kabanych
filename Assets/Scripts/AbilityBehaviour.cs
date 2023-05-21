using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class AbilityBehaviour : MonoBehaviour
{
    KabanychBehaviour kabanych;

    [SerializeField] 
    Vector3 k_offsetPos = Vector3.zero;

    [SerializeField]
    GameObject k_fakeCoin;

    private void Awake()
    {
        kabanych = FindAnyObjectByType<KabanychBehaviour>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InstantiateFakeCoin()
    {
        Instantiate(k_fakeCoin, kabanych.transform.position + k_offsetPos, Quaternion.identity);
    }


}
