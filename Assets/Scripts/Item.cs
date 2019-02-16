public class Item {
  private static ItemId      id;
  private static string      name;
  private static string      description;
  private static int         value;
  private static ItemType    type;

  public void Item(ItemId id, string name, string description, int value, ItemType type) {
    this.id          = id;
    this.name        = name;
    this.description = description;
    this.value       = value;
    this.type        = type;
  }

  public ItemId GetId() => id;

  public string GetName() => name;

  public string GetDescription() => description;

  public int GetValue() => value;

  public ItemType GetType() => type;
}
