using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeControl : MonoBehaviour
{
    [SerializeField]private GameObject[] GNodes;
    [SerializeField]private Sprite[] NodeSprites;
    void Start(){
      GNodes = GameObject.FindGameObjectsWithTag("Node");

      for(int i = 0; i < GNodes.Length; i++){
        GNodes[i].AddComponent<SpriteRenderer>();
        }

      }


    void Update()
    {
      for(int i = 0; i < GNodes.Length; i++){
          SpriteRenderer renderer = GNodes[i].GetComponent<SpriteRenderer>();
        string ControlString = GNodes[i].GetComponent<NodeInfo>().nodetype.ToString();

        switch(ControlString){
          case "Empty":
          GNodes[i].GetComponent<SpriteRenderer>().sprite = NodeSprites[0];
            break;

          case "Control":
          GNodes[i].GetComponent<SpriteRenderer>().sprite = NodeSprites[1];
            break;

          case "Information":
          GNodes[i].GetComponent<SpriteRenderer>().sprite = NodeSprites[2];
            break;

          case "IO":
          GNodes[i].GetComponent<SpriteRenderer>().sprite = NodeSprites[3];
            break;

          case "Door":
          GNodes[i].GetComponent<SpriteRenderer>().sprite = NodeSprites[4];
            break;

          default:
            break;
        }
      }
    }
}
