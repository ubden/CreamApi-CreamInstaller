### CreamInstaller: Automatic DLC Unlocker Installer & Configuration Generator

# ⚠️ Disclaimer (Read before installation and Follow Us on Github !)

> **This software is an open-source project developed for the community and is not affiliated with any organization or institution.**  
> It is shared purely for **educational purposes**, software development testing, and to contribute to the growth of the open-source community.

---

### ⚖️ Legal Responsibility
By using this software, you agree that:
- **All responsibility lies with you, the user.**
- The platform and its contributors provide this software **"as is"**, without any warranty of any kind, express or implied.  
  This includes, but is not limited to, the warranties of **merchantability**, **fitness for a particular purpose**, or **non-infringement**.  

> ⚠️ **Use it at your own risk.**

---

### 🎯 Intended Use
The primary purpose of this project is to:
- Educate the community by sharing open-source code.
- Facilitate learning and encourage innovation through open collaboration.

❌ **This software is not intended for production use.**  
We strongly recommend purchasing and using professionally licensed software for your needs.

---

### 🙌 Support the Community
If you would like to support the community and this project, consider making a donation:  
[![Donate](https://img.shields.io/badge/Donate-Click%20Here-orange?style=for-the-badge&logo=paypal)](https://ubd.one/donate)

---

### 🚨 Report Abuse
If you encounter any abuse or misuse of this software, please report it to:  
📧 **[abuse@ubden.com](mailto:abuse@ubden.com)**

---

> Thank you for being a part of the open-source community! 🌟


###### The program utilizes the latest versions of [Koaloader](https://github.com/acidicoala/Koaloader), [SmokeAPI](https://github.com/acidicoala/SmokeAPI), [ScreamAPI](https://github.com/acidicoala/ScreamAPI), [Uplay R1 Unlocker](https://github.com/acidicoala/UplayR1Unlocker) and [Uplay R2 Unlocker](https://github.com/acidicoala/UplayR2Unlocker), all by the wonderful [acidicoala](https://github.com/acidicoala), and all downloaded from the posts above and embedded into the program itself; no further downloads necessary on your part!
---
#### Description:
Automatically finds all installed Steam, Epic and Ubisoft games with their respective DLC-related DLL locations on the user's computer,
parses SteamCMD, Steam Store and Epic Games Store for user-selected games' DLCs, then provides a very simple graphical interface
utilizing the gathered information for the maintenance of DLC unlockers.

The primary function of the program is to **automatically generate and install DLC unlockers** for whichever
games and DLCs the user selects; however, through the use of **right-click context menus** the user can also:
* automatically repair the Paradox Launcher
* open parsed Steam and/or Epic Games appinfo in Notepad(++)
* refresh parsed Steam and/or Epic Games appinfo
* open root game directories and important DLL directories in Explorer
* open SteamDB, ScreamDB, Steam Store, Epic Games Store, Steam Community, Ubisoft Store, and official game website links (where applicable) in the default browser

---
#### Features:
* Automatic download and installation of SteamCMD as necessary whenever a Steam game is chosen. *For gathering appinfo such as name, buildid, listofdlc, depots, etc.*
* Automatic gathering and caching of information for all selected Steam and Epic games and **ALL** of their DLCs.
* Automatic DLL installation and configuration generation for Koaloader, SmokeAPI, ScreamAPI, Uplay R1 Unlocker and Uplay R2 Unlocker.
* Automatic uninstallation of DLLs and configurations for Koaloader, CreamAPI, SmokeAPI, ScreamAPI, Uplay R1 Unlocker and Uplay R2 Unlocker.
* Automatic reparation of the Paradox Launcher (and manually via the right-click context menu "Repair" option). *For when the launcher updates whilst you have CreamAPI, SmokeAPI or ScreamAPI installed to it.*

---
#### Installation:
1. Click [here]([https://github.com/pointfeev/CreamInstaller/releases/latest/download/CreamInstaller.zip](https://github.com/ubden/CreamApi/releases)) to download the latest release from [GitHub]([https://github.com/pointfeev/CreamInstaller](https://github.com/ubden/CreamApi/releases)).
2. Extract the executable to anywhere on your computer you want. *It's completely self-contained.*

If the program doesn't seem to launch, try downloading and installing [.NET 7 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/thank-you/runtime-7.0.2-windows-x64-installer).

---
#### Building from Source:
To build the project from source code, you need:
1. [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0) or later
2. Visual Studio 2022 (or later) with .NET desktop development workload, or Visual Studio Code with C# extension

**Note:** While the application targets .NET 7, you can build it with .NET 8 SDK or later. The `global.json` file ensures SDK compatibility.

---
#### **NOTE:** This program does not automatically download nor install actual DLC files for you. As the title of the program says, it's only a DLC Unlocker installer. Should the game you wish to unlock DLC for not already come with the DLCs installed (very many do not), you have to find, download, and install those yourself. Preferably, you should be referring to the proper cs.rin.ru post for the game(s) you're tinkering with; you'll usually find any answer to your problems there.

---
#### Usage:
1. Start the program executable. *Read above under Installation if it doesn't launch.*
2. Choose which programs and/or games the program should scan for DLC. *The program automatically gathers all installed games from Steam, Epic and Ubisoft directories.*
3. Wait for the program to download and install SteamCMD (if you chose a Steam game). *Very fast, depends on internet speed.*
4. Wait for the program to gather and cache the chosen games' information & DLCs. *May take a good amount of time on the first run, depends on how many games you chose and how many DLCs they have.*
5. **CAREFULLY** select which games' DLCs you wish to unlock. *Obviously none of the DLC unlockers are tested for every single game!*
6. Choose whether or not to install with Koaloader, and if so then also pick the proxy DLL to use. *If the default version.dll doesn't work, then see [here](https://forum.ubden.com.tr/konu/creaminstaller-auto-dlc-unlocker-installer-config-gen.1602/#google_vignette) to find one that does.*
7. Click the **Generate and Install** button.
8. Click the **OK** button to close the program.
9. If any of the DLC unlockers cause problems with any of the games you installed them on, simply go back to step 5 and select what games you wish you **revert** changes to, and instead click the **Uninstall** button this time.

---
##### Bugs/Crashes/Issues:
For reliable and quick assistance, all bugs, crashes and other issues should be referred to the [GitHub Issues]([https://github.com/](https://github.com/ubden/CreamApi/issues)) page!

---


