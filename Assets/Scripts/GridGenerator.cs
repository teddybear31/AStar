using System;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public GameObject cellPrefab;
    private int width = 10; // Largeur de la grille (sur l'axe X)
    private int depth = 10; // Profondeur de la grille (sur l'axe Z)
    public float cellSize = 1.0f; // Taille de chaque cellule

    public Dictionary<Vector2Int, Tile> Tiles { get; set; }

     
    internal void Generate(int width, int depth)
    {
        this.width = width;
        this.depth = depth;
        Tiles = new Dictionary<Vector2Int, Tile>();
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < depth; z++)
            {
                GameObject newCell = Instantiate(cellPrefab, new Vector3(x * cellSize, 0, z * cellSize), Quaternion.identity);
                newCell.name = $"Cell_{x}_{z}";
                newCell.transform.parent = this.transform;
                newCell.GetComponent<Tile>().SetObstacle(false);
                Tiles.Add(new Vector2Int(x,z), newCell.GetComponent<Tile>());
            }
        }
    }

    void Start()
    {
    }


    internal void SetEnd(Vector2Int end)
    {
        Tiles[end].SetEnd(true);
    }

    internal void SetObstacles(List<Vector2Int> obstacles)
    {
        foreach (Vector2Int obstacle in obstacles)
        {
            Tiles[obstacle].SetObstacle(true);
        }
    }

    internal void SetBegin(Vector2Int begin)
    {
        Tiles[begin].SetBegin(true);
    }

    /*
    internal void UpdateText(Node currentNode)
    {
        Vector2Int pos = new Vector2Int(currentNode.X, currentNode.Y);
        Tiles[pos].UpdateText(currentNode);
    }

    internal void SetInClosedSet(Node node, bool isInClosedSet)
    {
        Vector2Int pos = new Vector2Int(node.X, node.Y);
        Tiles[pos].SetInClosedSet(isInClosedSet);
    }

    internal void SetInOpenSet(Node node, bool isInOpenSet)
    {
        Vector2Int pos = new Vector2Int(node.X, node.Y);
        Tiles[pos].SetInOpenSet(isInOpenSet);
    }

    internal void SetIsCurrentNode(Node node, bool isCurrentNode)
    {
        Vector2Int pos = new Vector2Int(node.X, node.Y);
        Tiles[pos].SetIsCurrentNode(isCurrentNode);
    }

    internal void SetInFinalPath(Node node, bool isInFinalPath)
    {
        Vector2Int pos = new Vector2Int(node.X, node.Y);
        Tiles[pos].SetInFinalPath(isInFinalPath);
    }
    */
}
