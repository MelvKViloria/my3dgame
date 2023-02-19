using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
 private void OnTriggerEnter2D(Collider2D collision) 
 
  
 {
  if (collision.gameObject.CompareTag("Finish"))
  {
    SceneManager.LoadScene(1);
    Application.Quit(); 
  }
 }
}
