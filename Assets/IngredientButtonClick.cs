using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientButtonClick : MonoBehaviour
{
    public string ingrName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Called when we click the button
    public void ActivateIngredient()
    {
        FindObjectOfType<CookingManager>().ActivateIngredient(ingrName);

    }
}
