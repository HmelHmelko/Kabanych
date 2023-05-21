using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ClerkBehaviour : MonoBehaviour
{
    KabanychBehaviour k_player;

    //Variables
    [SerializeField] private float health;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float clerkDamage;
    [SerializeField] private float damageRate;


    private bool enteredToReachZone;

    private void Awake()
    {
        k_player = FindAnyObjectByType<KabanychBehaviour>();
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);

    }

    private void FixedUpdate()
    {
        //rb2D.velocity = new Vector2(movementSpeed * Time.fixedDeltaTime, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "PlayerReachZone")
        {
            Debug.Log(this.gameObject + "Reached PlayerReachZone");
            movementSpeed = 0;
            enteredToReachZone = true;
            StartCoroutine(startDps(damageRate));
        }
    }

    IEnumerator startDps(float rate)
    {
        while (k_player.HP > 0 && enteredToReachZone)
        {
            //Debug.Log("its start");
            k_player.HP -= clerkDamage;
            yield return new WaitForSeconds(rate);
        }
    }
}
