using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CoinCounter cc;
    [Range(0, 5)] public float speed = 1f;
    public GameObject Square;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxisRaw("Horizontal");
        this.transform.Translate(xMove * speed * Time.deltaTime, 0, 0);


    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Death"))
        {
            Destroy(gameObject);
            print("player destroyed");
        }

        if (collision.gameObject.CompareTag("Coin"))
        {
            cc.coinCount++;
        }
    }
}