using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ingredient : MonoBehaviour, IPointerClickHandler
{
    public string ingrName;


    public void OnPointerClick(PointerEventData eventData)
    {
        //We have clicked an ingredient, so open the radial menu for it.
        FindObjectOfType<UIManager>().ToggleCookingMenu();
    }
}
