using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Toad")
        {
            other.gameObject.GetComponent<CharacterControllerBehaviour>().ClimbingLadder = true;
            other.gameObject.GetComponent<CharacterControllerBehaviour>().CurrentObjectTransform = this.gameObject.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Toad")
        {
            if(other.gameObject.GetComponent<CharacterControllerBehaviour>().ClimbingLadder == true)
            {
            other.gameObject.GetComponent<CharacterControllerBehaviour>().LeavingLadder = true;
            }

        }
    }
}
