using System;
using TMPro;
using UnityEngine;
public class Tile : MonoBehaviour
{
    public Material end;
    public Material begin;
    public Material normal;
    public Material open;
    public Material closed;
    public Material finalPath;
    public Material current;

    public GameObject obstacle;
    public MeshRenderer renderer;
    public TMP_Text text;

    public void Start()
    {
        //text.text = ""; 
    }

    internal void SetObstacle(bool isObstacle)
    {
         obstacle.SetActive(isObstacle);
        text.enabled = false;
    }

    internal void SetEnd(bool isEnd)
    {
        renderer.material = isEnd ? end : normal;     
    }

    internal void SetBegin(bool isBegin)
    {
        renderer.material = isBegin ? begin : normal;
    }
    /*
    internal void UpdateText(Node node)
    {
        text.enabled = true;
        text.text = "G = " + node.GCost + "\n" + "H = " + node.HCost + "\n" + "Tot = " + node.FCost;
    }
    */
    internal void SetInOpenSet(bool isOpenSet)
    {
        renderer.material = isOpenSet ? open : normal;
    }

    internal void SetInClosedSet(bool isClosedSet)
    {
        renderer.material = isClosedSet ? closed : normal;
    }

    internal void SetIsCurrentNode(bool isCurrentNode)
    {
        renderer.material = isCurrentNode ? current : normal;
    }

    internal void SetInFinalPath(bool isInFinalPath)
    {
        renderer.material = isInFinalPath ? finalPath : normal;
    }
}