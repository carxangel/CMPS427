﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class equipment{

    public Attributes equipmentAttributes;
    public string equipmentName;
    public string equipmentType;
    public slots validSlot;
    public int tier;


    private Dictionary<string, slots> slotList = new Dictionary<string, slots>();

    public enum slots
    {
        Head,
        Chest,
        Legs,
        Feet,
        Main,
        Off
    }

    public equipment()
    {
        equipmentAttributes = new Attributes();
        equipmentName = "default_equipment";
        equipmentType = "default_type";
        validSlot = slots.Head;
        tier = 0;
        slotList.Add("Head", slots.Head);
        slotList.Add("Legs", slots.Legs);
        slotList.Add("Feet", slots.Feet);
        slotList.Add("Chest", slots.Chest);
        slotList.Add("Main", slots.Main);
        slotList.Add("Off", slots.Off);
    }

    public void setslot(string setto)
    {
        validSlot = slotList[setto];
    }

}
