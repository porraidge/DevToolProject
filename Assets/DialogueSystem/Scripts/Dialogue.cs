using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    public string characterName;
    [Tooltip("Toggle icon box on/off")]
    public bool hasIcon;
    public Image iconImage;

    [TextArea(3, 10)]
    public string[] sentences;

}
