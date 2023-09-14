
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public int id;
    public Slot parentslot;

    public void Init(int id, Slot slot)
    {
        this.id = id;
        this.parentslot = slot;
    }
}
