using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPacks : MonoBehaviour {}

public struct Coordinates {
    public int X { get; }
    public int Y { get; }


    public Coordinates(int xCoord, int yCoord) {
        X = xCoord;
        Y = yCoord;
    }
}