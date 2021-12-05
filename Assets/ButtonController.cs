using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{

    // Setup button agar dapat memulai ulang game
    public void ButtonRestart() {    
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);                
    }

    // Setup button agar dapat keluar aplikasi
    public void Exit() {
        Application.Quit();
    }
}
