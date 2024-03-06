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

    private enum InteractableObject
    {
      CupHolder = 6,
      Cup = 7,
      Dispenser = 8,
      Trash = 9,
      SubmitButton = 10,
      CupDispenser = 11
    }

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
      if(Input.GetMouseButtonDown(0))
      {
        switch(interactbleObject.layer)
        {
          case (int)InteractableObject.CupHolder:
          if(hasCup)
          {
            interactbleObject.GetComponent<Interactable>().Interact0(currentCup);
            currentCup = null;
            hasCup = false;
          }
          break;
          case (int)InteractableObject.Cup:
          //does nothing
          break;
          case (int)InteractableObject.Dispenser:
          interactbleObject.GetComponent<Interactable>().Interact0(null);
          break;
          case (int)InteractableObject.Trash:
          if(hasCup)
          {
            interactbleObject.GetComponent<Interactable>().Interact0(currentCup);
            currentCup = null;
            hasCup = false;
          }
          break;
          case (int)InteractableObject.SubmitButton:
          interactbleObject.GetComponent<Interactable>().Interact0(null);
          break;
          case (int)InteractableObject.CupDispenser:
          //does nothing
          break;
        }

      }
      if(Input.GetMouseButtonDown(1) && !hasCup)
      {
        switch(interactbleObject.layer)
        {
          case (int)InteractableObject.CupHolder:
          if(!interactbleObject.GetComponent<CupHolder>().cantTakeCup)
          {
            currentCup = interactbleObject.GetComponent<Interactable>().StoredCup;
            interactbleObject.GetComponent<Interactable>().Interact1(cupHolder);
            if(currentCup is not null) hasCup = true;
          }
          break;
          case (int)InteractableObject.Cup:
          interactbleObject.GetComponent<Interactable>().Interact1(cupHolder);
          currentCup = interactbleObject;
          hasCup = true;
          break;
          case (int)InteractableObject.Dispenser:
          //does nothing
          break;
          case (int)InteractableObject.Trash:
          //does nothing
          break;
          case (int)InteractableObject.SubmitButton:
          //does nothing
          break;
          case (int)InteractableObject.CupDispenser:
          interactbleObject.GetComponent<Interactable>().Interact1(cupHolder);
          currentCup = cupHolder.transform.GetChild(0).gameObject;
          hasCup = true;
          break;
        }
      }
    }
}
