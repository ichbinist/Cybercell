using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMapCreator : MonoBehaviour
{
  public string MapName;
  public void AddMap(){
    GameObject map = new GameObject();
    map.name = MapName;
  }
}
