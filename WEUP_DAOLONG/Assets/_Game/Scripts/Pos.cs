using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pos")]
public class Pos : ScriptableObject
{
    public List<Pdata> pdata;
}

public enum PosType
{
    p_1 = 0,
    p_2 = 1,
    p_3 = 2,
    p_4 = 3,
    p_5 = 4,
    p_6 = 5,
    p_7 = 6,
    p_8 = 7,
    p_9 = 8,
    p_10 = 9,
    p_11 = 10,
    p_12 = 11,
    p_13 = 12,
    p_14 = 13,
    p_15 = 14,
    p_16 = 15,
}
