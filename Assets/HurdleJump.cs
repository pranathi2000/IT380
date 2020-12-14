using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurdleJump : MonoBehaviour
{
    public GameObject canvas;
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
        //canvas.GetComponent<CanvasUIFunctions>().trackCarb.GetComponent<Rigidbody2D>().velocity *= -1;
    }
}
