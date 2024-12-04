using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using TMPro;

public class FoodCannon : MonoBehaviour
{
    [SerializeField] private float foodSpeed = 30;
    [SerializeField] private Transform ShootPoint;
    [SerializeField] private List<GameObject> foodList;
    [SerializeField] private GameObject shootEffect;
    [SerializeField] private TMP_Text scoretext;

    private void Start()
    {
        scoretext.text = "Hallo";
    }

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }    
    }

    private void Shoot()
    {
        Instantiate(shootEffect, ShootPoint.position, Quaternion.identity);
        GameObject randomFood = foodList[Random.Range(0, foodList.Count)];
        GameObject newFood = Instantiate(randomFood, ShootPoint.position, Random.rotation);
        if (newFood.GetComponent<Rigidbody>() != null)
        {
            //newFood.GetComponent<Rigidbody>().velocity = ShootPoint.forward * foodSpeed;
        } 
            
       
    }
}
