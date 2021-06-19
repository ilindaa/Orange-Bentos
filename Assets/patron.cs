using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patron : MonoBehaviour
{

    public string orderedMeat = "hamburger"; // later on randomize it
    public Transform coinObj;

    void OnMouseOver() {
        if((gameplay.deleteFood == "y") && (gameplay.currentMeat == orderedMeat)) {
            Destroy(gameObject);
            gameplay.deleteFood = "n";
            Instantiate(coinObj,new Vector2(-7.57f, 2.34f), coinObj.rotation);
        }
    }

}
