using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    // Serialize for debugging purposes
    [SerializeField] int breakableBlocks;

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }

}
