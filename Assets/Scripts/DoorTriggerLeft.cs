using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerLeft : MonoBehaviour
{
    [SerializeField] GameObject objectToActivate;

    // Start is called before the first frame update
    void Start()
    {
        objectToActivate.GetComponent<MoveDoorLeft>().enabled = true;
        objectToActivate.GetComponent<CloseDoorLeft>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private Color m_oldColor = Color.red;

    private void OnTriggerEnter(Collider other){
    Renderer render = GetComponent<Renderer>();
    m_oldColor = render.material.color;
    render.material.color = Color.green;
    objectToActivate.GetComponent<CloseDoorLeft>().enabled = false;
    objectToActivate.GetComponent<MoveDoorLeft>().enabled = true;
    }

    void OnTriggerExit(Collider other){
    Renderer render = GetComponent<Renderer>();
    render.material.color = m_oldColor;
    objectToActivate.GetComponent<MoveDoorLeft>().enabled = false;
    objectToActivate.GetComponent<CloseDoorLeft>().enabled = true;
    }
}
