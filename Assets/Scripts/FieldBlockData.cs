using UnityEngine;
using System.Collections.Generic;

public class FieldBlockData : MonoBehaviour{
    //world position
    private int _x;
    private int _y;
    private bool _occupied;
    private List<FieldBlockData> neighbours;
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

    FieldBlockData(int positionX, int postitionY) {
        X = positionX;
        Y = postitionY;
        Illuminance = 0;
    }
    FieldBlockData(int positionX, int postitionY, float illuminanceValue) {
        X = positionX;
        Y = postitionY;
        Illuminance = illuminanceValue;
    }

    public void AddNeighbour(FieldBlockData neighbour) { if(!neighbours.Contains(neighbour)) neighbours.Add(neighbour); }
    public List<FieldBlockData> GetNeighbours() { return neighbours; }
    public void SetIlluminance(float luxValue) { Illuminance = luxValue; }
    public void Occupy() { IsOccupied = true; }
    public void Free() { IsOccupied = false; }
}
