using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{

    void OnCollisionEnter ( Collision collision) 
     {
        if (collision.gameObject.name =="player")
        {
            SceneManager.LoadScene(0);
        }

        
     }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
