# Sunrider Legends Tactics - Performance Fix Mod

# What is Performance Fix Mod?
This is a mod for the visual novel [Sunrider Legends Tactics](https://store.steampowered.com/app/3854880/Sunrider_Legends_Tactics/) developed by [Love In Space](https://linktr.ee/loveinspace).

# What's new in this mod?
Several low-end machines may show performance issues during naval battles, reaching very low FPS to the point of making it unplayable, uncomfortable, or taking too much time to advance.

With this mod enabled, the FPS during battles should increase at the cost of a slightly lower quality water.

![Mod Off screenshot, better water quality, 9 FPS](performance_off.png)
*Original game screenshot, showing better water quality, but roughly 10 FPS.*

![Mod Off screenshot, slightly worse water quality, 40 FPS](performance_on.png)
*Modded game screenshot, showing a slightly worse water quality, but a stable 40 FPS.*

This mod was tested with these systems and the results were the following:

| OS | CPU | RAM | GPU | Mod OFF Average FPS | Mod ON Average FPS|
| --- | --- | --- | --- | --- | --- |
| Windows 11 Pro | AMD Ryzen 5 PRO 3500U @ 2.10GHz | 16GB | AMD Radeon Vega 8 | 10 | 40 |
| Windows 10 Pro | Intel Core i5 8100 @ 3.6GHz | 8GB | Intel UHD Graphics 630 | 9 | 35 |

# How to install?

### Requirements
- Sunrider Legends Tactics v1.2.1.0 (should work for any version)
- [Undertale Mod Tool](https://github.com/UnderminersTeam/UndertaleModTool/releases) GUI v0.8.4.1 (latest tested working version). Do not mistake and pick the CLI version.
- `SunriderLegendsPerformanceFix.csx` script provided here.

### Steps
-  Open the Sunrider Legends game folder and make sure to create a backup of `data.win` just in case, in case you break something. If you don't, that's your choice.
- Open UndertaleModTool.
- Drop down the `File` menu, select `Open` and choose the `data.win` file in the Sunrider Legends game folder.
- Drop down the `Script` menu, select `Run other script...` and choose the `SunriderLegendsPerformanceFix.csx` script file.
- You will be shortly after prompted whether you want to use the performance mode. Select `Yes` to use it, select `No` if you want to revert to the original state.
- Drop down the `File` menu, select `Save` and overwrite the `data.win` file in the Sunrider Legends game folder.
- Play the game and verify it worked successfully.
- Enjoy!

- **WARNING**: Reinstalling, verifying files integrity, or updating the game will undo this mod. You will need to reapply it.

# Changelog

## v0.1

- Initial release.