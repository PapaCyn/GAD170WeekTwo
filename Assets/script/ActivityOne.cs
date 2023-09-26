using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityOne : MonoBehaviour
{
    public string faveGame = "Binding of Isaac: Rebirth";
    public int hoursPlayed = 183;
    public float howMuch = 29.95f; 
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("My favourite game is "
            + faveGame + " I have played it for " + hoursPlayed
            + "hours." + "It cost $" + howMuch + "." + " My dollars per hour is: "
            + howMuch / hoursPlayed);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
