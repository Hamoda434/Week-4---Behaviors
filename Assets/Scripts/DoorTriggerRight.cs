using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerRight : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;

    // Start is called before the first frame update
    void Start()
    {
        objectToActivate.GetComponent<MoveDoorRight>().enabled = true;
        objectToActivate.GetComponent<CloseDoorRight>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnTriggerEnter(Collider other){
    objectToActivate.GetComponent<CloseDoorRight>().enabled = false;
    objectToActivate.GetComponent<MoveDoorRight>().enabled = true;
    }

    void OnTriggerExit(Collider other){
        objectToActivate.GetComponent<MoveDoorRight>().enabled = false;
        objectToActivate.GetComponent<CloseDoorRight>().enabled = true;
    }
}
