using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
  
    public void Win()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Exit()
    {
        Exit();
    }
}
