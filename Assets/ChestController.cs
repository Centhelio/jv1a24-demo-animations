using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    [SerializeReference] Animator door;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            print("Opend Chest!");
            door.SetBool("IsOpen", true);
            
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player")){
            print("Close Chest!");
            door.SetBool("IsOpen", false);

        }

    }
}
