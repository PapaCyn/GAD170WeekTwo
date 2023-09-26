using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivityThree : MonoBehaviour
{
    public int strength;
    public int agility;
    public int intelligence;
    public int statPool;

    // Start is called before the first frame update
    void Start()
    {
        //set stat pool value
        statPool = 20;

        //strength stat
        strength = Random.Range(0, statPool);
        statPool = statPool - strength;

        //agility stat
        agility = Random.Range(0, statPool);
        statPool = statPool - agility;

        //intelligence stat
        intelligence = Random.Range(0, statPool);
        statPool = statPool - intelligence ;
        
    }

    // Update is called once per frame
    void Update()
    {
        //If we hit the E key on our keyboard
        if (Input.GetKeyDown(KeyCode.E))
        {
            //Print stats to console
            Debug.Log("My stats are:");
            Debug.Log("Strength: " + strength);
            Debug.Log("Agility: " + agility);
            Debug.Log("Intelligence: " +  intelligence);
        }
    }
}
