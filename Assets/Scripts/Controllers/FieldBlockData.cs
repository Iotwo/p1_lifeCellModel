using UnityEngine;
using System.Collections.Generic;

public class FieldBlockData : MonoBehaviour {
    private int _x;
    private int _y;
    private bool _occupied;
    private List<FieldBlockData> _neighbours;
    private float _illuminance;

    public int X {
        get { return _x; }
        set { _x = value; }
        }
    public int Y {
        get { return _y; }
        private set { _y = value; }
    }
    public float Illuminance {
        get { return _illuminance; }
        private set { _illuminance = value; }
    }
    public bool IsOccupied {
        get { return _occupied; }
        private set { _occupied = value;}
    }
    public IReadOnlyCollection<FieldBlockData> Neighbours { get { return _neighbours; } }


    public void SetCoordinates(int xCoord, int yCoord){
        X = xCoord;
        Y = yCoord;
    }


    public void SetIlluminance(float luxValue) { Illuminance = luxValue; }
    public void Occupy() { IsOccupied = true; }
    public void Free() { IsOccupied = false; }
    public void AddNeighbour(FieldBlockData neighbour) { if (!_neighbours.Contains(neighbour)) _neighbours.Add(neighbour); } 
}
