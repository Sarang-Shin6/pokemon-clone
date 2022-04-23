using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
    MoveBase Base { get; set; }
    public int Pp { get; set; }

    public Move(MoveBase pBase)
    {
        Base = pBase;
        Pp = pBase.Pp;
    }
}
