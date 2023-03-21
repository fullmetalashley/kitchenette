using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ClickDetection : MonoBehaviour, IPointerDownHandler
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Detects when this object is clicked
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Clicked!" + this.gameObject.name);
        //Use this for opening rooms. Move to a new area

    }
}
