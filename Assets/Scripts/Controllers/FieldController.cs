using UnityEngine;
using System;

public class FieldController : MonoBehaviour
{
    [SerializeField] private GameObject _fieldBlockPrefab;
    private Camera _mainCam;
    private FieldData _fieldData; 
    private EnlightmentGrid _enlightmentGrid;
    private OccupationGrid _occupationGrid;
    private NeighboursList _neighboursList;
    private BlockInfoDisplayer _blockInfoDisplayer;

    public EnlightmentGrid EnlightmentGrid {
        get { return _enlightmentGrid; }
        private set { _enlightmentGrid = value; }
    }
    public OccupationGrid OccupationGrid {
        get { return _occupationGrid; }
        private set { _occupationGrid = value; }
    }
    public NeighboursList NeighboursList {
        get { return _neighboursList; }
        private set { _neighboursList = value; }
    }
    
    // Start is called before the first frame update
    void Start() {
        _mainCam = Camera.main;
        //hope this make subcomponents exist
        _fieldData = GetComponent<FieldData>();
        _enlightmentGrid = GetComponent<EnlightmentGrid>();
        _neighboursList = GetComponent<NeighboursList>();
        _occupationGrid = GetComponent<OccupationGrid>();
        _blockInfoDisplayer = GetComponent<BlockInfoDisplayer>();

        InitializeField(_fieldData.Width, _fieldData.Height);
    }

    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            Debug.Log("LMB Pressed: " + Input.mousePosition);
        }

        if (Input.GetMouseButtonDown(0)){ // if left button pressed...
            Ray ray = _mainCam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit)){
                int X = (int)Math.Round(hit.transform.position.x,0);
                int Y = (int)Math.Round(hit.transform.position.y,0);
                Debug.Log(String.Format("Name: {0}; X:{1}; Y:{2};",hit.collider.gameObject.name, X, Y));
                _blockInfoDisplayer.DisplayBlockInfo(X, Y).PrintBlockData();
            }
        }  
    }

    private void InitializeField(int height, int width) {
        int i=0, j=0;
        
        _enlightmentGrid.Activate(height, width);
        _neighboursList.Activate(height, width);
        _occupationGrid.Activate(height, width);

        for(i = 0; i < height; i++)
            for(j = 0; j < width; j++) {
                Instantiate(_fieldBlockPrefab, new Vector3(i,j,0), Quaternion.identity, this.gameObject.transform).name=String.Format("Block_{0}-{1}",i,j);
            }
    }  
}
