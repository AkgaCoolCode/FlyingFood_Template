using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect : MonoBehaviour
{
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Player"))
        {
            print("collectable");
            scoreManager.instance.ChangeScore(5);
            timer.instance.ResetTimer();
            Destroy(gameObject); 

        }


    }
}
