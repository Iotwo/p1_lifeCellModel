using UnityEngine;

public class FieldInitializer : MonoBehaviour
{
    [SerializeField] private GameObject _fieldBlockPrefab;
    private FieldData _fieldData; 
    
    // Start is called before the first frame update
    void Start() {
        _fieldData = GetComponent<FieldData>();
        InitializeField(_fieldData.Width, _fieldData.Height);
    }

    private void InitializeField(int height, int width) {
        int i=0, j=0;
        for(i = 0; i < height; i++)
            for(j = 0; j < width; j++)
                Instantiate(_fieldBlockPrefab, new Vector3(i,j,0), Quaternion.identity, this.gameObject.transform);
    }  
}
