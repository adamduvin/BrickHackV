public class DailyEvent {
  private static DailyEventId id;
  private static string       name;
  private static string       description;

  public void DailyEvent(DailyEventId id, string name, string description) {
    this.id          = id;
    this.name        = name;
    this.description = description;
  }

  public DailyEventId GetId() => id;

  public string GetName() => name;

  public string GetDescription() => description;
}
