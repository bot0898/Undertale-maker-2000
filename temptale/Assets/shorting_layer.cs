using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shorting_layer : MonoBehaviour
{
    public string LayerName;
    public int SortingOrder;
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<MeshRenderer>().sortingLayerName = LayerName;
        //Order in Layerの数値
        this.GetComponent<MeshRenderer>().sortingOrder = SortingOrder;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
