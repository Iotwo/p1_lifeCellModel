using System.Collections.Generic;
using UnityEngine;


// this data uses only to give sizes to grids
public class FieldData : MonoBehaviour {
    private int _width;
    private int _heigth;

    public int Width {
        get { return _width; }
        private set { _width = value; }
    }   
    public int Height {
        get { return _heigth; }
        private set { _heigth = value; }
    } 


    public void SetFieldSize(int xSize, int ySize) {
        Width = xSize;
        Height = ySize;
    }
}
