using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bincontrol : MonoBehaviour
{
    // controls when u click on the bins raw and prepped food gets placed down in the pan/bento
    public Transform bentoboxObj;
    public Transform riceObj;
    public Transform umeboshiObj;
    public Transform vegetableObj;
    public Transform rawpattyObj;
    public Transform rawtamagoyakiObj;
    public Transform tomatoesObj;
    public Transform rawtakoObj;

    public int occupiedSlot = 100; // for every food item it's attached to
    public string mousecontrolled = "n";

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
    }

    void OnMouseDown() {
        if(gameObject.name == "bento box bin") {
            if(gameplay.bentoS1 == "empty") {
                Instantiate(bentoboxObj,new Vector2(-0.85f, -1.31f), bentoboxObj.rotation);
                gameplay.bentoS1 = "justbento";
                gameplay.selectedSlot = 1; // checking slot 1
            } else if(gameplay.bentoS2 == "empty") {
                Instantiate(bentoboxObj,new Vector2(-0.85f, -3.65f), bentoboxObj.rotation);
                gameplay.bentoS2 = "justbento";
                gameplay.selectedSlot = 2; // checking slot 1
            }
        }

        if(gameObject.name == "patty bin"){
            if(gameplay.panS1 == "empty") {
                Instantiate(rawpattyObj, new Vector2(2.99f, -2.006f), rawpattyObj.rotation);
                gameplay.panS1 = "justpatty";
            }
        }

        if(gameObject.name == "tako bin") {
            if(gameplay.panS2 == "empty") {
                Instantiate(rawtakoObj, new Vector2(2.316f, -1.842f), rawtakoObj.rotation);
                gameplay.panS2 = "justtako";
            } 
        }

        if(gameObject.name == "tamagoyaki bin") {
            if(gameplay.panS3 == "empty") {
                Instantiate(rawtamagoyakiObj, new Vector2(2.896f, -1.273f), rawtamagoyakiObj.rotation);
                gameplay.panS3 = "justtamagoyaki";
            }
        }

        if(gameObject.name == "rice bin") {
            if(gameplay.bentoS1 != "empty") {
                Instantiate(riceObj, new Vector2(-1.5f, -1.3f), riceObj.rotation); 
            } else if(gameplay.bentoS2 != "empty") {
                Instantiate(riceObj, new Vector2(-1.5f, -3.64f), riceObj.rotation); 
            }
        }

        if(gameObject.name == "umeboshi bin") {
            if(gameplay.bentoS1 != "empty") {
                Instantiate(umeboshiObj, new Vector2(-1.5f, -1.3f), umeboshiObj.rotation); 
            } else if(gameplay.bentoS2 != "empty") {
                Instantiate(umeboshiObj, new Vector2(-1.5f, -3.64f), umeboshiObj.rotation); 
            }
        }

        if(gameObject.name == "vegetable bin") {
            if(gameplay.bentoS1 != "empty") {
                Instantiate(vegetableObj, new Vector2(-0.2110004f, -1.1f), vegetableObj.rotation); 
            } else if(gameplay.bentoS2 != "empty") {
                Instantiate(vegetableObj, new Vector2(-0.2110004f, -3.44f), vegetableObj.rotation); 
            }
        }

        if(gameObject.name == "tomato bin") {
            if(gameplay.bentoS1 != "empty") {
                Instantiate(tomatoesObj, new Vector2(-0.3f, -1.85f), tomatoesObj.rotation); 
            } else if(gameplay.bentoS2 != "empty") {
                Instantiate(tomatoesObj, new Vector2(-0.3f, -4.19f), tomatoesObj.rotation); 
            }
        }


    }

}
