using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookfood : MonoBehaviour
{

    public Sprite cookedPatty;
    public Sprite cookedTako;
    public Sprite cookedTamagoyaki;
    public float cookingTime = 0;

    public int occupiedSlot = 100; // for every food item it's attached to
    public string mousecontrolled = "n";
    public string toppingStatus;

    // gameObject.GetComponent<SpriteRenderer>().sprite = cookedPatty;

    // Update is called once per frame
    void Update()
    {
        Debug.Log (occupiedSlot + " " + gameplay.selectedSlot);

        if(occupiedSlot == gameplay.selectedBento) { // position of patty only moves if = to bento
            mousecontrolled = "y";
            Vector2 mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objPosition = Camera.main.ScreenToWorldPoint (mousePosition);
            transform.position = new Vector2(objPosition.x, objPosition.y);
            if(gameObject.name == "1patty(Clone)") { // change later to patty
                gameplay.currentMeat = "hamburger";
            }
        }

        if((gameplay.deleteFood == "y") && (mousecontrolled == "y")) {
            Destroy(gameObject);
        }

        cookingTime += Time.deltaTime;
        if((cookingTime > 5 && cookingTime < 10) && (transform.position.x > 1)) {
            GetComponent<SpriteRenderer> ().color = new Color (1, 1, 0);
        }

        if((cookingTime > 10) && (transform.position.x > 1)) {
            GetComponent<SpriteRenderer> ().color = new Color (0, 0, 0);
        }

    }

    void OnMouseDown() {

        if(transform.position.x == 2.99f) {
            gameplay.panS1 = "empty";

            if((gameplay.bentoS1 == "justbento") && (toppingStatus != "placed")) {
                GetComponent<Transform>().position = new Vector2(-0.328f, -1.213f); // y changes -2.34
                // gameplay.bentoS1 = "fullpatty";
                occupiedSlot = 1; // oS
                // toppingStatus = "placed";
            } else if((gameplay.bentoS2 == "justbento") && (toppingStatus != "placed")) {
                GetComponent<Transform>().position = new Vector2(-0.328f, -3.553f);
                // gameplay.bentoS2 = "fullpatty";
                occupiedSlot = 2;
                // toppingStatus = "placed";
            }

        }

        if(transform.position.x == 2.316f) {
            gameplay.panS2 = "empty";

            if((gameplay.bentoS1 == "justbento") && (toppingStatus != "placed")) {
                GetComponent<Transform>().position = new Vector2(0.08f, -1.65f); // y changes -2.34
                // gameplay.bentoS1 = "fulltako";
                occupiedSlot = 1; // oS
                // toppingStatus = "placed";
            } else if((gameplay.bentoS2 == "justbento") && (toppingStatus != "placed")) {
                GetComponent<Transform>().position = new Vector2(0.08f, -3.99f);
                // gameplay.bentoS2 = "fulltako";
                occupiedSlot = 2;
                // toppingStatus = "placed";
        }

        }

        if(transform.position.x == 2.896f) {
            gameplay.panS3 = "empty";

            if((gameplay.bentoS1 == "justbento") && (toppingStatus != "placed")) {
                GetComponent<Transform>().position = new Vector2(0.17f, -1.02f); // y changes -2.34
                // gameplay.bentoS1 = "fulltamagoyaki";
                occupiedSlot = 1; // oS
                // toppingStatus = "placed";
            } else if((gameplay.bentoS2 == "justbento") && (toppingStatus != "placed")) {
                GetComponent<Transform>().position = new Vector2(0.17f, -3.36f);
                // gameplay.bentoS2 = "fulltamagoyaki";
                occupiedSlot = 2;
                // toppingStatus = "placed";
        }

        }

    }
}