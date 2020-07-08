using UnityEngine;

public class EnlightmentGrid : MonoBehaviour {
    private float [,] _enlightment;

    public float [,] Enlightment{
        get { return _enlightment; }
        private set { _enlightment = value; }
    }


    public void SetEnlightment(int xCoord, int yCoord, float enlightVal) { Enlightment[xCoord, yCoord] = enlightVal; }
}