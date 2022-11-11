using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScenScript : MonoBehaviour
{
    private void Start()
    {
        
    }
    private void Update()
    {
        
    }
    static public void OnStartButton()
    {
        SceneManager.LoadScene("MatchingScene");
    }
}