using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("collectable");
        if (collision.transform.CompareTag("Player"))
        {
          
        }
    }
}
