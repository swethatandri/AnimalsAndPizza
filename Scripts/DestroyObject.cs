using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    // Start is called before the first frame update
    private float upperBound = 30f;
    private float lowerBound = -10f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > upperBound){
            Destroy(gameObject);
        }
        else if(transform.position.z < lowerBound){
            Debug.Log("Game Over!");

            Destroy(gameObject);

        }
    }
}
