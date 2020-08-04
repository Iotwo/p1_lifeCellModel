using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this unit used to read values of the grids

public class BlockInfoDisplayer : MonoBehaviour
{ 
    private bool GetOccupationData(int xPosition, int yPosition){
        return GetComponent<OccupationGrid>().Occupation[xPosition,yPosition];
    }
    private float GetEnlightmentData(int xPosition, int yPosition){
        return GetComponent<EnlightmentGrid>().Enlightment[xPosition,yPosition];
    }
    private List<Coordinates> GetNeighboursData(int xPosition, int yPosition){
        return (List<Coordinates>)GetComponent<NeighboursList>().Neighbours[xPosition, yPosition];
    }
    public FieldBlockData DisplayBlockInfo(int blockPositionX, int blockPositionY){
        return new FieldBlockData(blockPositionX, blockPositionY,
                                  GetOccupationData(blockPositionX, blockPositionY),
                                  GetEnlightmentData(blockPositionX, blockPositionY),
                                  GetNeighboursData(blockPositionX, blockPositionY));
    }
}
