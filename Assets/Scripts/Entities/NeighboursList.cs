using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NeighboursList : MonoBehaviour {
    private int neighboursCount = 8;
    private List<Coordinates> [,] _neighbours;

    public IReadOnlyCollection<Coordinates>[,] Neighbours { get { return _neighbours; } }

    public void AddNeighbour(int xCoord, int yCoord, Coordinates neighbour) { 
        if(!_neighbours[xCoord, yCoord].Contains(neighbour)) 
            _neighbours[xCoord, yCoord].Add(neighbour); 
    }

    public void Activate(int neighboursMatrixSizeX, int neighboursMatrixSizeY) {
        int i,j,x,y; //iterators
        int localNeighbourX, localNeighbourY;
        _neighbours = new List<Coordinates>[neighboursMatrixSizeX,neighboursMatrixSizeY];
        for (i=0; i< neighboursMatrixSizeX; i++)
            for(j=0;j<neighboursMatrixSizeY; j++) {
                _neighbours[i,j] = new List<Coordinates>(neighboursCount);
                for(x=i-1; x<=i+1;x++) {
                    localNeighbourX = x;
                    if (x<0) localNeighbourX = neighboursMatrixSizeX + x;
                    else { if (x>neighboursMatrixSizeX - 1) localNeighbourX = x - neighboursMatrixSizeX; }
                    for(y=j-1;y<=j+1;y++) {
                        localNeighbourY = y;
                        if (y<0) localNeighbourY = neighboursMatrixSizeY + y;
                        else { if (y>neighboursMatrixSizeY - 1) localNeighbourY = y - neighboursMatrixSizeY; }
                        if (x!=i || y!=j) AddNeighbour(i,j,new Coordinates(localNeighbourX, localNeighbourY));
                    }
                }
            }
    }
}
