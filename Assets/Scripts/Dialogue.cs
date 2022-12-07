using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue
{
    public string characterName;
    public bool hasIcon;
    public Sprite characterIcon;

    [TextArea(3, 10)]
    public string[] sentences;

}
