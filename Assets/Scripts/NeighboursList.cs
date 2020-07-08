using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeighboursList : MonoBehaviour {
    private List<Coordinates> [,] _neighbours;

    public IReadOnlyCollection<Coordinates>[,] Neighbours { get { return _neighbours; } }

    public void AddNeighbour(int xCoord, int yCoord, Coordinates neighbour) { 
        if(!_neighbours[xCoord, yCoord].Contains(neighbour)) 
            _neighbours[xCoord, yCoord].Add(neighbour); 
    }
}
