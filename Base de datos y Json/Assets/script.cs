using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class script : MonoBehaviour
{
    
    public void backToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void goToRanking()
    {
        SceneManager.LoadScene(1);
    }
}
