using Sirenix.OdinInspector;
using Sirenix.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GachaConfigSO", menuName = "Game/GachaConfig")]
public class GachaConfig : SerializedScriptableObject
{
    public List<GachaSingleItemData> allGachaData;

    public Dictionary<Rarity, float> rarityChanceConfig;
}

[Serializable]
public class GachaSingleItemData
{
    public ItemWithAmountData itemWithAmountData;
    public Rarity rarity;
}

public enum Rarity
{
    Common,
    Uncommon,
    Rare,
    Legendary,
    Unique
}