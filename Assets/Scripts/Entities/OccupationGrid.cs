using UnityEngine;

public class OccupationGrid : MonoBehaviour {
    private bool [,] _occupation;

    public bool [,] Occupation{
        get { return _occupation; }
        private set { _occupation = value; }
    }


    public void SetOccupation(int xCoord, int yCoord, bool isOccupied) { Occupation[xCoord, yCoord] = isOccupied; }
}
