using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameplay : MonoBehaviour
{
    public static string bentoS1 = "empty"; // cuttingboard slot #
    public static string bentoS2 = "empty";

    public static string panS1 = "empty"; // grill
    public static string panS2 = "empty";
    public static string panS3 = "empty";

    public static int selectedSlot = 0;
    public static int selectedBento = 0;

    public KeyCode giveFood;
    public static string deleteFood = "n";
    public static string currentMeat;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(giveFood)) {
            deleteFood = "y";
        }
    }
}
