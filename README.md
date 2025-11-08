# Valheim UI Mod - Display Day & Time Countdown

Simple UI mod that near the minimap, displays both the day count and a how much of the current day or night is left (in minutes/seconds). This is a modified version of the mod [Display Day and Time in HUD](https://www.nexusmods.com/valheim/mods/861), which displays an in-game clock rather than a countdown in IRL.

## Prerequisites

- Install a mod manager like [R2Modman](https://thunderstore.io/package/ebkr/r2modman/).
- Install [BepInExPack Valheim](https://thunderstore.io/c/valheim/p/denikson/BepInExPack_Valheim/) with mod manager.

## Install from Thunderstore

Install [DayTimeCountdown](https://thunderstore.io/c/valheim/p/Aidin/DayTimeCountdown/) with mod manager.

## Build from source

1. Install .NET SDK (Core 3.1 or later) from [Microsoft](https://dotnet.microsoft.com/en-us/download).
2. Download source code from [GitHub](https://github.com/aidinabedi/ValheimDayTimeCountdown).
3. Build release with .NET CLI command: `dotnet build -c Release`
4. Import generated `ValheimDayTimeCountdown.zip` as local mod using mod manager.

## Configuration

The configuration file for this mod is automatically generated the first time you run the game with the mod installed. You can find it in your local
BepInEx config directory (`BepInEx\config\ValheimDayTimeCountdown.cfg`).

You can customize the following settings in the configuration file:

1. **Display under minimap**: Default is `false`. If set to `false`, the panel appears above the minimap; if set to `true`, it appears below.
2. **Display time**: Default is `true`. Enables or disables the time countdown display.
3. **Display day**: Default is `true`. Enables or disables the day count display.
4. **Display background**: Default is `true`. Shows or hides the background panel behind the text.
5. **Font name**: Default is `AveriaSansLibre-Bold`. If this font is not available in resources, it will fall back to the default.
6. **Font size**: Default is `16`. Sets the size of the displayed text.
7. **Font color**: Default is `RGBA(1, 1, 1, 0.791)`. Sets the color and transparency of the text.
8. **Background color**: Default is `RGBA(0, 0, 0, 0.3921569)`. Sets the color and transparency of the background panel.
9. **Text outline color**: Default is `black`. Sets the color of the text outline.
10. **Text outline enabled**: Default is `true`. Enables or disables the text outline.
11. **Margin between minimap and panel**: Default is `0`. Sets the space between the minimap and the panel.
12. **Padding (left and right)**: Default is `10`. Sets the horizontal padding between the text and the panel border.
13. **Reverse text position**: Default is `false`. If set to `true`, the time is displayed on the left and the day on the right.
14. **Panel width**: Default is `200`. Sets the width of the panel.
15. **Panel height**: Default is `30`. Sets the height of the panel.
