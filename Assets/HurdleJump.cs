using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurdleJump : MonoBehaviour
{
    public Rigidbody2D g;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("TRIGGERED");
        //g.AddForce(Vector2.up * 100);
        Vector2 pos;
        pos = g.transform.position;
        pos.y += 10;
        g.transform.position = pos;
        //pos.y -= 3;
        g.transform.position = pos;
    }
}
