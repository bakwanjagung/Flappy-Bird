using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitFlappy : MonoBehaviour
{
    public void doQuitFlappy() {
     Debug.Log ("has quit game");
     Application.Quit();
    }
}
