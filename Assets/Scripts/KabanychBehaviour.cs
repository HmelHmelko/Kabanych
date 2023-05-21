using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KabanychBehaviour : MonoBehaviour
{
    [SerializeField] private float health;

    //Properties
    public float HP { get { return health; } set { health = value; } }

    // Start is called before the first frame update
    void Start()
    {
        health = 5.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Destroy(this.gameObject);
            Debug.Log("Game Over");
        }
        
    }
}
