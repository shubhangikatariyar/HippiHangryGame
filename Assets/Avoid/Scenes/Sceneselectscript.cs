using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneselectscript : MonoBehaviour
{
    public void selectScene(){
        switch (this.gameObject.name){
            case "playbutton":
            SceneManager.LoadScene ("Game Scene");
            break; 
        }
    }
}
