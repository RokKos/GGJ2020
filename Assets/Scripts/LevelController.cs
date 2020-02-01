using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class LevelController : MonoBehaviour
{    
    public enum Axis {KHorizontal, KVertical};

    [SerializeField]
    private Levels levels = null;
    [SerializeField]
    private GameObject prefabTile = null; 
    
    // Start is called before the first frame update
    void Start()
    {
        Level level = levels.levels[0]; 
        for(int i = 0; i < level.height; i++) {
            for(int j = 0; j < level.width; j++) {
                GameObject tile = Instantiate(prefabTile, new Vector3(i,j, 0),Quaternion.identity,this.gameObject.transform);
                MeshRenderer mr = tile.GetComponent<MeshRenderer>();
                Material mat = mr.material;
                mat.SetFloat("_ErosionFactor", level.levelLayout[i * level.height + j] * 0.1f);
                
            }
        }
        
        
    }
    
    
    void ApplyBuldozer(Vector2 coord, Axis axis){

        switch (axis)
        {
            case Axis.KHorizontal:
            case Axis.KVertical:
            default:
                Debug.Log("WARNING WRONG AXIS");
                break;
        }
    }
    
    

    
    
        
    
}
