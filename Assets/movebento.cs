using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movebento : MonoBehaviour
{

    public int occupiedSlot = 0; // what slot the bento is in - accepts gameplay.selectedSlot
    public string mousecontrolled = "n"; // mouse control = no

    // Start is called before the first frame update
    void Start()
    {
        occupiedSlot = gameplay.selectedSlot;
        Debug.Log(occupiedSlot);
    }

    // Update is called once per frame
    void Update()
    {
        if(mousecontrolled == "y") { // if yes then u set the mouse coord to unity coord and then update it to the object's position
            Vector2 mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
            transform.position = objPosition;
        }

        if((gameplay.deleteFood == "y") && (mousecontrolled == "y")) {
            Destroy(gameObject);
        }

    }

    void OnMouseDown() {
        mousecontrolled = "y";
        gameplay.selectedBento = occupiedSlot; // capture which bento is being clicked (move bento and need to move ingredients along too)
    }
}
