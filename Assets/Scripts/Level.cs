using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] int breakableBlocks; // Serialized for debugging purpose

    public void CountBreakableBlocks()
    {
        breakableBlocks++;
    }
}
