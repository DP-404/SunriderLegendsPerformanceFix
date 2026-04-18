using UndertaleModLib;

EnsureDataLoaded();

bool UsePerformance = ScriptQuestion("Use Performance Mode?");

foreach (var room in Data.Rooms) {
    if (!room.Name.Content.Contains("_battle"))
        continue;

    foreach (var layer in room.Layers) {
        if (
            layer.LayerName.Content.StartsWith("Effect_")
            || layer.LayerName.Content.StartsWith("Deep")
        )
            layer.IsVisible = !UsePerformance;
    }
}

SyncBinding("Rooms", true);
DisableAllSyncBindings();
