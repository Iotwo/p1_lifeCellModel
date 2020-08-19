using UnityEngine;
using System;

public class FieldInitialiser : MonoBehaviour
{
    [SerializeField] private GameObject _fieldBlockPrefab;
    private FieldData _fieldData; 
    private EnlightmentGrid _enlightmentGrid;
    private OccupationGrid _occupationGrid;
    private NeighboursList _neighboursList;
    
    // Start is called before the first frame update
    void Start() {
        _fieldData = GetComponent<FieldData>();
        _enlightmentGrid = GetComponent<EnlightmentGrid>();
        _neighboursList = GetComponent<NeighboursList>();
        _occupationGrid = GetComponent<OccupationGrid>();

        InitializeField(_fieldData.Width, _fieldData.Height);
    }

    private void InitializeField(int height, int width) {
        int i=0, j=0, x=0, y=0;
        
        _enlightmentGrid.Activate(height, width);
        _neighboursList.Activate(height, width);
        _occupationGrid.Activate(height, width);

        for(i = 0; i < height; i++)
            for(j = 0; j < width; j++) {
                Instantiate(_fieldBlockPrefab, new Vector3(i,j,0), Quaternion.identity, this.gameObject.transform);
                for(x=i-1; x<=i+1;x++)
                    for(y=j-1;y<=j+1;y++)
                        if(x>-1 && x<height && y>-1 && y<width)
                            if (x!=i || y!=j)
                                _neighboursList.AddNeighbour(i,j,new Coordinates(x,y));
            }
    }  
}
