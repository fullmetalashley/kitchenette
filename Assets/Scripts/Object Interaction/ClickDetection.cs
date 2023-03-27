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

        //If this object has an ingr attached, we can open the cooking menu. 
        //Otherwise, we should open one of the storage menus. For now, stick with fridge.
        if (this.gameObject.GetComponent<Ingredient>())
        {
            //If we have one, open cooking.
            FindObjectOfType<UIManager>().ToggleCookingMenu();
        }
        else
        {
            FindObjectOfType<UIManager>().ToggleFridgeMenu();
        }
    }
}
