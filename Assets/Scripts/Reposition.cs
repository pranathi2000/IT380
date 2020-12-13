using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reposition : MonoBehaviour
{
    public GameObject g;
    // Start is called before the first frame update
    void Start()
    {
        g.gameObject.transform.localScale = new Vector3(5.8f, 3.7f, 1.0f);
        g.gameObject.transform.localPosition = new Vector3(0f, 0f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 secondPosition = new Vector3(0f,190f, 0f );
        Vector3 secondScale = new Vector3(2.4f, 1.5f, 0.41f);
        while (g.gameObject.transform.position.x > secondPosition.x )
        {
            g.gameObject.transform.position = new Vector3(g.gameObject.transform.position.x + 0.001f, g.gameObject.transform.position.y, g.gameObject.transform.position.z);
            g.gameObject.transform.localScale = new Vector3(g.gameObject.transform.localScale.x + 0.001f, g.gameObject.transform.localScale.y, g.gameObject.transform.localScale.z);
        }

    }
}
