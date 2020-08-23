using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Coordinates {
    public int X { get; }
    public int Y { get; }


    public Coordinates(int xCoord, int yCoord) {
        X = xCoord;
        Y = yCoord;
    }

    public string Print() { return (String.Format("{0};{1}",X, Y)); }
}


public class FieldBlockData {
    private int _x;
    private int _y;
    private bool _occupied;
    private List<Coordinates> _neighbours;
    private float _illuminance;

    public int X {
        get { return _x; }
        private set { _x = value; }
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
    public List<Coordinates> Neighbours { 
        get { return _neighbours; } 
        private set { _neighbours = value; }
    }


    public FieldBlockData(int xCoord, int yCoord, bool occupation, float illuminance, List<Coordinates> neighbours){
        X = xCoord;
        Y = yCoord;
        Illuminance = illuminance;
        IsOccupied = occupation;
        Neighbours = neighbours;
    }

    public void PrintBlockData() {
        string neighbours = String.Empty;
        
        for (int i = 0; i<Neighbours.Count; i++)
            neighbours+="{" + Neighbours[i].Print() + "}";

        Debug.Log(String.Format("Coordinates:[{0},{1}]; Illuminance: {2}; Occupation: {3}; Neighbours: [{4}];",
                                X, Y, Illuminance, IsOccupied, neighbours));
    }
}