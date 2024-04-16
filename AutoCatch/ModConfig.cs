using StardewModdingAPI;
using StardewModdingAPI.Utilities;

namespace AutoCatch;

public sealed class ModConfig
{
    public Keybind ToggleModButton { get; set; } = new Keybind(SButton.OemTilde);
    public bool EnableMod { get; set; } = true;
}