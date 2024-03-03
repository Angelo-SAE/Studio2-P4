using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cup : Interactable
{
    public int flavorIndex;
    public Material nextFlavor;
    public Material[] flavors;

    public void Start()
    {
        GetComponent<Renderer>().materials = flavors;
    }

    public Material GetMeshMaterialAtIndex(int flavor)
    {
        return GetComponent<Renderer>().materials[flavor];
    }

    public void AddFlavor()
    {
        Material currentMaterial = GetMeshMaterialAtIndex(flavorIndex);

        if(String.Equals(currentMaterial.name, nextFlavor.name))
        {
            ;
        } else {
            Material[] flavors = GetComponent<Renderer>().materials;
            flavors[flavorIndex] = nextFlavor;
            GetComponent<Renderer>().materials = flavors;
        }
    }

    public override void Interact0(GameObject obj)
    {
      transform.parent = obj.transform;
      transform.localPosition = Vector3.zero;
    }

    public override void Interact1(GameObject obj)
    {
      Debug.Log("1");
    }
}
