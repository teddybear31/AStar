using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AStar : MonoBehaviour
{
    public int width = 10; // Largeur de la grille (sur l'axe X)
    public int depth = 10; // Profondeur de la grille (sur l'axe Z)
    public Vector2Int begin;
    public Vector2Int end;
    public List<Vector2Int> obstacles;
    public GridGenerator grid;


    // Start is called before the first frame update
    void Start()
    {
        grid.Generate(width, depth);
        grid.SetBegin(begin);
        grid.SetEnd(end);
        grid.SetObstacles(obstacles);

    }

}
