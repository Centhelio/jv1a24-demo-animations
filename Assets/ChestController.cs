using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    [SerializeReference] Animator chest;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){
            print("Opend Chest!");
            chest.SetBool("IsOpen", true);
            
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player")){
            print("Close Chest!");
            chest.SetBool("IsOpen", false);

        }

    }
}
