using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{

    [SerializeField] private List<GameObject> allFoods;
    // Start is called before the first frame update
    void Start()
    {
        foreach (var food in allFoods)
        {
            food.gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Resetfood()
    {
        bool exists = false;
        while (!exists)
        {
            GameObject randomfood = allFoods[Random.Range(0, allFoods.Count)].gameObject;
            if (randomfood != null)
            {
                  randomfood.SetActive(true);
            }
        
        }
       
    }
}
