using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeCoinBehaviour : MonoBehaviour
{
    [SerializeField] private float coinSpeed;
    [SerializeField] private float coinReturnSpeedMultiplier;

    //Function variables
    bool isCoinHitEnemy;


    private void Awake()
    {
    }
    void Start()
    {
    }
    void Update()
    {
        if (!isCoinHitEnemy)
        {
            ThrowCoin();
        }
        else
        {
            ReturnCoin();
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "EnemyClerk")
        {
            //Debug.Log(this.gameObject + " Destroy " + other.gameObject.name);
            isCoinHitEnemy = true;
            Destroy(other.gameObject);
        }

        if(other.tag == "Player")
        {
            isCoinHitEnemy = false;
            Destroy(this.gameObject);
        }
    }

    private void ThrowCoin()
    {
        transform.Translate(Vector3.right * coinSpeed * Time.deltaTime);
    }

    private void ReturnCoin()
    {
        this.transform.Translate(Vector3.left * coinSpeed * coinReturnSpeedMultiplier * Time.deltaTime);
    }
}
