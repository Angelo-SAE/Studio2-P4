using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DebugFlavorChanger : MonoBehaviour
{
    public float timePassed;
    public float changingTime;
    public GameObject Cup;

    // Update is called once per frame
    void Update()
    {
        timePassed += Time.deltaTime;

        if (timePassed > changingTime)
        {
            Cup.Interactable.Cup.AddFlavor(Smoothie_Watermelon);
        }
    }
}
