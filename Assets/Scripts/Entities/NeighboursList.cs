using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeighboursList : MonoBehaviour {
    private List<Coordinates> [,] _neighbours;

    public IReadOnlyCollection<Coordinates>[,] Neighbours { get { return _neighbours; } }

    public void Awake() {}

    public void AddNeighbour(int xCoord, int yCoord, Coordinates neighbour) { 
        if(!_neighbours[xCoord, yCoord].Contains(neighbour)) 
            _neighbours[xCoord, yCoord].Add(neighbour); 
    }

    public void Activate(int neighboursMatrixSizeX, int neighboursMatrixSizeY) {
        _neighbours = new List<Coordinates>[neighboursMatrixSizeX,neighboursMatrixSizeY];
        for (int i=0; i< neighboursMatrixSizeX; i++)
            for(int j=0;j<neighboursMatrixSizeY; j++)
                _neighbours[i,j] = new List<Coordinates>(8);
    }
}
