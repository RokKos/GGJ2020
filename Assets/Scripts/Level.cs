using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Level", menuName = "ScriptableObjects/Level", order = 1)]
public class Level : ScriptableObject {
    
    public List<int> levelLayout;
    public int width;
    public int height;
    public List<Moves> moves;
    public float changeOfOffspring;
    public int startTrees;

    
    [Serializable]
    public enum Moves {
        KBuldozer = 0,
        KKrt = 1,
        KLubadar = 2,
        KPozar = 3,
        KGozdar = 4,
        KLast = 5
    }
}