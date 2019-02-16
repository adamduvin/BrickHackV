public class ItemType {
  private ItemTypeId id;
  private string     name;
  private string     description;

  public void ItemType(ItemTypeId id, string name, string description) {
    this.id          = id;
    this.name        = name;
    this.description = description;
  }

  public ItemClassId GetId() => id;

  public string GetName() => name;

  public string GetDescription() => description;
}
