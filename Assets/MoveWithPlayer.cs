using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("TrackCarb").active == true)
        {
            player = GameObject.Find("TrackCarb").transform;
            //transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z); // Camera follows the player with specified offset position
        }
    
}
}
