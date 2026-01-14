using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpHeight;
    public GameObject coin;
    public int numCoins;
    private bool isGrounded;

    public GameController controller;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && isGrounded)
        {
            //Debug.Log("hit space");
            isGrounded = false;
            gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("hit ground");
        isGrounded = true;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        numCoins += 1;
        controller.updatePointsText(numCoins);

        Destroy(collision.gameObject);
    }
    
}
