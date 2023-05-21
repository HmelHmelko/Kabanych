using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class AbilityBehaviour : MonoBehaviour
{
    KabanychBehaviour k_player;
    ClerkSpawn c_spawnedEnemy;


    [SerializeField] Vector3 k_offsetPos = Vector3.zero;


    [SerializeField] GameObject k_fakeCoin;
    [SerializeField] private float coinRate;

    private void OnEnable()
    {
        c_spawnedEnemy.onEnemySpawned += InstantiateFakeCoin;
    }

    private void OnDisable()
    {
        c_spawnedEnemy.onEnemySpawned -= InstantiateFakeCoin;
    }

    private void Awake()
    {
        k_player = FindAnyObjectByType<KabanychBehaviour>();
        c_spawnedEnemy = FindAnyObjectByType<ClerkSpawn>();
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
        StartCoroutine(fakeCoinPuller());
        //Instantiate(k_fakeCoin, k_player.transform.position + k_offsetPos, Quaternion.identity);
    }

    IEnumerator fakeCoinPuller()
    {
        while(k_player.HP >= 0)
        {
            Instantiate(k_fakeCoin, k_player.transform.position + k_offsetPos, Quaternion.identity);
            yield return new WaitForSeconds(coinRate);
        }
    }

}
