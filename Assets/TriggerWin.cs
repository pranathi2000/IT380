using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TriggerWin : MonoBehaviour
{
    public GameObject resultsPanel;
    public GameObject canvas;
    public TMP_Text Output;
    public TMP_Text Des;
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
        Debug.Log("I am at the trigger method");
        if (other.tag == "win")
        {
            other.tag = "stop";
            Debug.Log("I WIN");
            resultsPanel.SetActive(true);
            canvas.GetComponent<CanvasUIFunctions>().move = false;
            Output.text = "YOU WIN!";
            Des.text = "The complex carbs really gave us an extra boost at this race!";
        }
        if (other.tag == "lose")
        {
            other.tag = "stop";
            Debug.Log("I LOSE");
            resultsPanel.SetActive(true);
            canvas.GetComponent<CanvasUIFunctions>().move = false;
            Des.text = "Better luck next time!";
            Output.text = "YOU LOSE!";
        }
    }
}
