﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetGame : MonoBehaviour
{
    public void reset()
    {
        PlayerPrefs.DeleteAll();
    }
}
