using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this unit used to read or change values of FieldBlockData
// other controlles should get their data through this one

public class BlockDataTransferController : MonoBehaviour
{
    public Coordinates GetFieldBlockCoordinates(FieldBlockData target) {
        return new Coordinates(target.X, target.Y);
    }
    public float GetFieldBlockIlluminance(FieldBlockData target) { return target.Illuminance; }
    public bool GetFieldBlockOccupation(FieldBlockData target) { return target.IsOccupied; }
    public IReadOnlyCollection<FieldBlockData> GetFieldBlockNeighbours(FieldBlockData target) {
        return target.Neighbours;
    }

    public void SetFieldBlockCoordinates(FieldBlockData target, int anewCoordX, int anewCoordY) {
        target.SetCoordinates(anewCoordX, anewCoordY);
    }
    public void SetFieldBlockIlluminance(FieldBlockData target, float illuminanceValue) {
        target.SetIlluminance(illuminanceValue);
    }
    public void SetFieldBlockOccupied(FieldBlockData target) { target.Occupy(); }
    public void SetFieldBlockFreed(FieldBlockData target) { target.Free(); }
    public void AddNeighbourToFieldBloc(FieldBlockData target, FieldBlockData neighbour) { target.AddNeighbour(neighbour); }
}
