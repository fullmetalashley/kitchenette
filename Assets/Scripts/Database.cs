using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Database : MonoBehaviour
{
    public List<Ingr> allIngredients;
    public List<Recipe> allRecipes;
    public List<Tool> allTools;

    public List<GameObject> allSceneIngredients;
    public Dictionary<string, GameObject> activeIngredientObjects;
    
    // Start is called before the first frame update
    void Start()
    {
        //Setup the dictionary, which will hold all of the active game objects. 
        activeIngredientObjects = new Dictionary<string, GameObject>();
        
        for (int i = 0; i < allSceneIngredients.Count; i++)
        {
            activeIngredientObjects.Add(allSceneIngredients[i].GetComponent<Ingredient>().thisIngr.name, 
                allSceneIngredients[i]);
        }

        //Turn all of these objects off
        foreach (KeyValuePair<string, GameObject> pair in activeIngredientObjects)
        {
            pair.Value.SetActive(false);
        }
    }
}
