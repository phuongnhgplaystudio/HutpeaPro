using System;

public enum ItemType
{
   None,
   Coin,
   Diamond,
   NormalChest,
   RareChest,
   LegendChest,
   BattlePassPoint
}

[Serializable]
public class ItemWithAmountData
{
    public ItemType itemType;
    public int amount;
}
