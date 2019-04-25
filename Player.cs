using System.Collections;
using System.Collections.Generic;
using Fungus;
using UnityEngine;

public class Player : MonoBehaviour
{
    private GameObject triggeringNPC;
    private bool triggering;
    public Flowchart flowchart;
    // Update is called once per frame
    void Update()
    {
        if (triggering)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                flowchart.ExecuteBlock("NPC Bob");
            }

        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Bob")
        {
            triggering = true;
            triggeringNPC = other.gameObject;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Bob")
        {
            triggering = false;
            triggeringNPC = null;
        }
    }
}
