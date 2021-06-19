using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movetoppings : MonoBehaviour
{
    public int occupiedSlot = 99;
    public string mousecontrolled = "n";

    // Start is called before the first frame update
    void Start()
    {
        occupiedSlot = gameplay.selectedSlot;
        Debug.Log(occupiedSlot);
    }


    // Update is called once per frame
    void Update()
    {
        if(occupiedSlot == gameplay.selectedBento) {
            mousecontrolled = "y";
            Vector2 mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
            transform.position = new Vector2(objPosition.x, objPosition.y-.2f);
        }

        if((gameplay.deleteFood == "y") && (mousecontrolled == "y")) {
            Destroy(gameObject);
        }

    }
}
