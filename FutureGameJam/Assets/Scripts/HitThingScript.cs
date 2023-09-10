using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitThingScript : MonoBehaviour
{
    public bool PlayerWonLevel;

    public GameObject WinMenu;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "HitThing")
        {
            Debug.Log("You Won");
            PlayerWonLevel = true;
            WinMenu.SetActive(true);
        }
    }
}
