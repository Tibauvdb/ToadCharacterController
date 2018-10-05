using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pluck : MonoBehaviour {
    [SerializeField]
    private int _requiredPulls;

    [SerializeField]
    private int _droppedItem;

    [SerializeField]
    private List<GameObject> _droppableItems = new List<GameObject>();

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Toad")
        {
            Debug.Log("Colliding with Toad");
            //If toad is in this trigger, allow the player to press B | Y | A to pluck the turnip
            //Has priority over moving around
            if(Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2") || Input.GetButtonDown("Fire3"))
            {
                //lower required pulls by one
                _requiredPulls--;

                if (_requiredPulls == 0)
                {
                    //Make something happen i.e Coin comes out
                    GameObject drop = Instantiate(_droppableItems[_droppedItem]);

                    

                    //Deactivate script when requiredPulls is 0
                    this.gameObject.GetComponent<Pluck>().enabled = false;
                }
            }
        }
    }
}
