public class DailyEventConfig {
  public static enum DailyEventId {
    DragonAttack,
    SkeletonHoard,
    Blizzard,
    FlyingCabbages,
    AlternateWorldSummoning,
    RobotUprising
  }

  private static Dictionary<DailyEventId, DailyEvent> DailyEvents = new Dictionary<DailyEventId, DailyEvent>{
    { DailyEventId.DragonAttack, new DailyEvent(DailyEventId.DragonAttack,
      "Dragon Attack",
      "Dragons came down from High Hrothgar! It seems some sheep were killed and crops were destroyed, but all of the townsfolk survived. The farmers will be looking to replant their fields as soon as possible in order to avoid a food shortage.") },

    { DailyEventId.SkeletonHoard, new DailyEvent(DailyEventId.SkeletonHoard,
      "Skeleton Hoard",
      "Skeletons invaded the town last night. While the townsfolk were sleeping, they managed to raid some houses and make off with valuable gems. The craftsmen are now pushing to build a wall in order to keep the skeletons out, but they'll need a lot of bricks to do so.") },

    { DailyEventId.Blizzard, new DailyEvent(DailyEventId.Blizzard,
      "Massive Blizzard",
      "In a blind rage, the evil king turned his weather machine to full blast. A blizzard covered the town with snow last night, and the townsfolk will need some big shovels to clear it up. Many kids will be looking for new boots so they can walk to school.") },

    { DailyEventId.FlyingCabbages, new DailyEvent(DailyEventId.FlyingCabbages,
      "Flying Cabbages Visit",
      "The cabbages have come to town! The townsfolk were delighted to see them all fly in, and some farmers even managed to capture a few. No doubt they'll be looking for food to go with their cabbage dinners over the next few days.") },

    { DailyEventId.AlternateWorldSummoning, new DailyEvent(DailyEventId.AlternateWorldSummoning,
      "Heroes Summoned from Alternate World",
      "To help fight the terrors facing our town, heroes from another world have graced us with their presence. They seem to be a little unaccustomed to our way of life, and may be looking for remnants from their home world in order to maintain comfort.") },

    { DailyEventId.RobotUprising, new DailyEvent(DailyEventId.RobotUprising,
      "Robot Uprising",
      "Robots from a neighboring town gained sentience and came over on a rampage yesterday. Our warriors managed to fend them off, but broke many of their weapons in the process. They'll need to restock quickly to prepare for the next battle.") }
  };

  Random random = new Random();

  public GetDailyEventById(DailyEventId id) => DailyEvents[id];

  public GetRandomDailyEvent() {
    Array dailyEventIds = Enum.GetValues(typeof(DailyEventId));
    DailyEventId id = (DailyEventId)dailyEventIds.GetValue(random.Next(dailyEventIds.length));
    return GetDailyEventById(id);
  }
}
