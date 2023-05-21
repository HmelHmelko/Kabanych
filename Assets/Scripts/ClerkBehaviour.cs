using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClerkBehaviour : MonoBehaviour
{

    Rigidbody2D rb2D;

    [SerializeField]
    private float movementSpeed;


    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
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
        }
    }
}
