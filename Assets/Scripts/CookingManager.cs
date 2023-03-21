using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookingManager : MonoBehaviour
{
    public List<GameObject> activeIngredients;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateIngredient(string ingredient)
    {
        for (int i = 0; i < activeIngredients.Count; i++)
        {
            if (activeIngredients[i].GetComponent<Ingredient>().ingrName == ingredient)
            {
                activeIngredients[i].SetActive(true);
            }
        }
    }
}
