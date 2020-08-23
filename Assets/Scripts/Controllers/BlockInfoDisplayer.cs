using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this unit used to read values of the grids

public class BlockInfoDisplayer : MonoBehaviour
{ 
    private FieldController _fieldController; // do I really need this?

    void Start() {
        _fieldController = GetComponent<FieldController>();
    }

    private bool GetOccupationData(int xPosition, int yPosition){
        return _fieldController.OccupationGrid.Occupation[xPosition,yPosition];
    }
    private float GetEnlightmentData(int xPosition, int yPosition){
        return _fieldController.EnlightmentGrid.Enlightment[xPosition,yPosition];
    }
    private List<Coordinates> GetNeighboursData(int xPosition, int yPosition){
        return (List<Coordinates>)_fieldController.NeighboursList.Neighbours[xPosition, yPosition];
    }
    public FieldBlockData DisplayBlockInfo(int blockPositionX, int blockPositionY){
        return new FieldBlockData(blockPositionX, blockPositionY,
                                  GetOccupationData(blockPositionX, blockPositionY),
                                  GetEnlightmentData(blockPositionX, blockPositionY),
                                  GetNeighboursData(blockPositionX, blockPositionY));
    }
}
