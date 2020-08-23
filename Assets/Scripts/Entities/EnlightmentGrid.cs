using UnityEngine;

public class EnlightmentGrid : MonoBehaviour {
    private float [,] _enlightment;

    public float [,] Enlightment{
        get { return _enlightment; }
        private set { _enlightment = value; }
    }

    public void Awake() {}

    public void SetEnlightment(int xCoord, int yCoord, float enlightVal) { Enlightment[xCoord, yCoord] = enlightVal; }

    public void Activate(int enlightmentGridSizeX, int enlightmentGridSizeY) {
        _enlightment = new float[enlightmentGridSizeX, enlightmentGridSizeY];
        for (int i=0;i<enlightmentGridSizeX;i++)
            for(int j=0;j<enlightmentGridSizeY;j++)
                _enlightment[i,j] = 0;
    }
}