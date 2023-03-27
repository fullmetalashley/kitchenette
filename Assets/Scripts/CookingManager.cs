using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingManager : MonoBehaviour
{
    public List<GameObject> activeIngredients;

    public List<Ingr> fridgeIngredients;

    private Database theDatabase;
    private UIManager theUI;

    void Start()
    {
        theDatabase = FindObjectOfType<Database>();
        theUI = FindObjectOfType<UIManager>();
    }

    //Called by IngredientButtonClick.
    //Adds the ingredient to the list of active ingredients and puts it in the environment.
    public void ActivateIngredient(string ingredient)
    {
        if (ReturnIngr(ingredient).count > 0)
        {
            //First: Find the object in the database
            theDatabase.activeIngredientObjects[ingredient].SetActive(true);
            DecreaseCount(ingredient);
            theUI.ToggleFridgeMenu();
        }
        else
        {
            Debug.Log("There isn't anything left!");
        }
    }

    public void DecreaseCount(string ingredient)
    {
        for (int i = 0; i < fridgeIngredients.Count; i++)
        {
            if (fridgeIngredients[i].name == ingredient)
            {
                fridgeIngredients[i].count--;
                FindObjectOfType<UIManager>().UpdateIngredientText(fridgeIngredients[i].count);
            }
        }
    }

    public Ingr ReturnIngr(string ingredient)
    {
        for (int i = 0; i < fridgeIngredients.Count; i++)
        {
            if (fridgeIngredients[i].name == ingredient)
            {
                return fridgeIngredients[i];
            }
        }

        return null;
    }
}
