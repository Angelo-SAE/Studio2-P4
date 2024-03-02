using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    [SerializeField] private GameObject cupHolder, lookFrom;
    [SerializeField] private LayerMask interactableLayers;
    [SerializeField] private float checkDistance;
    private GameObject interactbleObject, currentCup;
    private bool hasCup;

    void Update()
    {
      CheckForAndStoreInteractable();
      if(interactbleObject is not null)
      {
        Interact();
      }
    }

    private void CheckForAndStoreInteractable()
    {
      RaycastHit hit;
      Physics.Raycast(lookFrom.transform.position, lookFrom.transform.forward, out hit, checkDistance, interactableLayers);
      if(hit.transform is not null)
      {
        interactbleObject = hit.transform.gameObject;
      } else {
        interactbleObject = null;
      }
      Debug.DrawRay(lookFrom.transform.position, lookFrom.transform.forward * checkDistance);
    }

    private void Interact()
    {
      if(Input.GetMouseButtonDown(0) && !hasCup)
      {
        switch(interactbleObject.layer)
        {
          case 6:
          currentCup = interactbleObject.GetComponent<Interactable>().StoredCup;
          interactbleObject.GetComponent<Interactable>().Interact0(cupHolder);
          hasCup = true;
          break;
          case 7:
          interactbleObject.GetComponent<Interactable>().Interact0(cupHolder);
          currentCup = interactbleObject;
          hasCup = true;
          break;
          case 8:
          break;
        }

      }
      if(Input.GetMouseButtonDown(1) && hasCup)
      {
        switch(interactbleObject.layer)
        {
          case 6:
          interactbleObject.GetComponent<Interactable>().Interact1(currentCup);
          currentCup = null;
          hasCup = false;
          break;
          case 7:
          //does nothing
          break;
          case 8:
          break;
        }

      }
    }
}
