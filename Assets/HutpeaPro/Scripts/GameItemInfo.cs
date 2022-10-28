using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameItemInfoSO", menuName = "Game/GameItemInfo")]
public class GameItemInfo : ScriptableObject
{
    public List<ItemInfo> gameItemInfos;

    public ItemInfo GetItemInfoFromType(ItemType itemType)
    {
        return (from item in gameItemInfos
                where item.itemType == itemType
                select item).FirstOrDefault();
    }
}

[Serializable]
public class ItemInfo
{
    public ItemType itemType;
    public Sprite itemIcon;
    public Color itemColor;
}