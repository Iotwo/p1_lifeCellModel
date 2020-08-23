using UnityEngine;

public class OccupationGrid : MonoBehaviour {
    private bool [,] _occupation;

    public bool [,] Occupation{
        get { return _occupation; }
        private set { _occupation = value; }
    }


    public void Awake() {}

    public void SetOccupation(int xCoord, int yCoord, bool isOccupied) { Occupation[xCoord, yCoord] = isOccupied; }

    public void Activate(int occupationGridSizeX, int occupationGridSizeY) {
        _occupation = new bool[occupationGridSizeX, occupationGridSizeY];
        for (int i=0; i<occupationGridSizeX; i++)
            for(int j=0;j<occupationGridSizeY;j++)
                _occupation[i,j] = false;
    }
}
