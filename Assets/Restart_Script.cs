﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_Script : MonoBehaviour
{
   public void RestartGame()
    {
        SceneManager.LoadScene("Sample Scene");
    }
}
