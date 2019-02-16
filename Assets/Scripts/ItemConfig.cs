public class ItemConfig {
  public static enum ItemTypeId {
    Consumable,
    Weapon,
    Shield
  }

  public static enum ItemId {
    /* CONSUMABLES */
    HealthPotion,
    ManaPotion,

    /* WEAPONS */
    WoodenSword,
    IronSword,

    /* SHIELDS */
    WoodenShield,
    IronShield
  }

  private static Dictionary<ItemTypeId, ItemType> ItemTypes = new Dictionary<ItemTypeId, ItemType>{
    { ItemTypeId.Consumable, new ItemType(ItemTypeId.Consumable,
      "Consumable",
      "A single-use item which grants a temporary or lasting effect to the user.") },

    { ItemTypeId.Weapon, new ItemType(ItemTypeId.Weapon,
      "Weapon",
      "An offensive item which allows the user to attack enemies.") },

    { ItemTypeId.Shield, new ItemType(ItemTypeId.Shield,
      "Shield",
      "A defensive item which allows the user to defend against enemy attacks.") }
  };

  private static Dictionary<ItemId, Item> Items = new Dictionary<ItemId, Item>{
    { ItemId.HealthPotion, new Item(ItemId.HealthPotion,
      "Health Potion",
      "Restores a small amount of health.",
      200,
      GetItemTypeById(ItemTypeId.Consumable)) },

    { ItemId.ManaPotion, new Item(ItemId.ManaPotion,
      "Mana Potion",
      "Restores a small amount of mana.",
      300,
      GetItemTypeById(ItemTypeId.Consumable)) },

    { ItemId.WoodenSword, new Item(ItemId.WoodenSword,
      "Wooden Sword",
      "Deals a small amount of damage.",
      600,
      GetItemTypeById(ItemTypeId.Weapon)) },

    { ItemId.IronSword, new Item(ItemId.IronSword,
      "Iron Sword",
      "Deals a moderate amount of damage.",
      1200,
      GetItemTypeById(ItemTypeId.Weapon)) },

    { ItemId.WoodenShield, new Item(ItemId.WoodenShield,
      "Wooden Shield",
      "Blocks a small amount of damage.",
      700,
      GetItemTypeById(ItemTypeId.Shield)) },
    
    { ItemId.IronShield, new Imtem(ItemId.IronShield,
      "Iron Shield",
      "Blocks a moderate amount of damage.",
      1400,
      GetItemTypeById(ItemTypeId.Shield)) }
  };

  public ItemType GetItemTypeById(ItemTypeId id) => ItemTypes[id];

  public Item GetItemById(ItemId id) => Items[id];
}
