using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    // Start is called before the first frame update
    public PlayerController player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        // Runs by pressing the button
        player.klikDownTower();
    }


    private void OnMouseUp()
    {
        // Runs when button is released
        player.klikUpTower();
    }
}
