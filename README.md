<!-- ═══════════════════════════ OPENING SCENE ═══════════════════════════ -->
<div align="center">



<a href="https://github.com/ubden/CreamApi-CreamInstaller">
  <img src="https://readme-typing-svg.demolab.com?font=Fira+Code&weight=600&size=22&duration=3200&pause=900&color=FF8A00&center=true&vCenter=true&width=640&lines=Scan+your+Steam%2C+Epic+%26+Ubisoft+library.;Pick+the+DLC.+Hit+Generate+and+Install.;One+click+to+install.+One+click+to+revert.;Open+source.+No+obfuscation.+Built+by+the+community." alt="Typing intro" />
</a>

<br/>

[![Latest Release](https://img.shields.io/github/v/release/ubden/CreamApi-CreamInstaller?style=for-the-badge&logo=github&color=ff8a00&label=release)](https://github.com/ubden/CreamApi-CreamInstaller/releases/latest)
[![Downloads](https://img.shields.io/github/downloads/ubden/CreamApi-CreamInstaller/total?style=for-the-badge&logo=windows&color=302b63)](https://github.com/ubden/CreamApi-CreamInstaller/releases)
[![Stars](https://img.shields.io/github/stars/ubden/CreamApi-CreamInstaller?style=for-the-badge&logo=starship&color=f5c518)](https://github.com/ubden/CreamApi-CreamInstaller/stargazers)
[![.NET 9](https://img.shields.io/badge/.NET-9.0-512BD4?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
[![License: GPL v3](https://img.shields.io/github/license/ubden/CreamApi-CreamInstaller?style=for-the-badge&color=2ea44f)](LICENSE)

<br/>

<a href="https://github.com/ubden"><img src="https://img.shields.io/github/followers/ubden?label=Follow%20%40ubden&style=for-the-badge&logo=github&color=181717" alt="Follow @ubden on GitHub" /></a>
&nbsp;
<a href="https://ubd.one/donate"><img src="https://img.shields.io/badge/Donate-Fuel%20the%20Project-ff5f5f?style=for-the-badge&logo=githubsponsors&logoColor=white" alt="Donate" /></a>

<br/><br/>

<img src="https://github.com/user-attachments/assets/f91c4ee4-6145-4e9e-a638-acbf0ddae052" width="820" alt="CreamInstaller main window" />

<sub><i>▲ One window. Every launcher. Every DLC.</i></sub>

</div>

<br/>

> [!CAUTION]
> **Read the [disclaimer](#-act-v--the-fine-print) before installing.** This project is shared for **educational purposes**, is not affiliated with any organization, and is intended for experienced users only.

---

<!-- ═══════════════════════════ TABLE OF CONTENTS ═══════════════════════════ -->
<div align="center">

### 🎞️ The Reel

[**Act I** · The Premise](#-act-i--the-premise) &nbsp;•&nbsp;
[**Act II** · The Arsenal](#-act-ii--the-arsenal) &nbsp;•&nbsp;
[**Act III** · Lights, Camera, Install](#-act-iii--lights-camera-install) &nbsp;•&nbsp;
[**Act IV** · Behind the Scenes](#-act-iv--behind-the-scenes) &nbsp;•&nbsp;
[**Act V** · The Fine Print](#-act-v--the-fine-print) &nbsp;•&nbsp;
[**Credits**](#-end-credits) &nbsp;•&nbsp;
[**Post-Credits Scene**](#-post-credits-scene--join-the-cast)

</div>

---

## 🎬 Act I — The Premise

*Somewhere on your drive sit dozens of games, spread across Steam, Epic and Ubisoft Connect, each with its own DLL layout and its own DLC list.*

**CreamInstaller** finds every installed Steam, Epic (including **Heroic**) and Ubisoft game on your computer, along with each game's DLC-related DLL locations. It then queries **SteamCMD**, the **Steam Store** and the **Epic Games Store** for the DLCs of the games you select. All of that information lands in one simple interface for installing, configuring and removing DLC unlockers.

The main job is to **generate and install DLC unlocker configs automatically** for whichever games and DLCs you choose. Right-click any entry for more:

| 🖱️ Right-click action | What happens |
|---|---|
| 🔧 **Repair** | Repairs the Paradox Launcher |
| 📝 **Open appinfo** | Opens parsed Steam / Epic appinfo in Notepad(++) |
| 🔄 **Refresh** | Re-queries Steam / Epic appinfo |
| 📂 **Open folders** | Opens the root game directory and important DLL directories in Explorer |
| 🌐 **Open links** | SteamDB, ScreamDB, Steam Store, Epic Games Store, Steam Community, Ubisoft Store and official game websites |

---

## ⚡ Act II — The Arsenal

<table>
<tr>
<td width="50%" valign="top">

### 🧠 Smart discovery
- Scans **Steam**, **Epic Games**, **Heroic** and **Ubisoft Connect** libraries
- Downloads and installs **SteamCMD** by itself when a Steam game is selected
- Gathers and caches appinfo (name, buildid, listofdlc, depots…) for **every** DLC

</td>
<td width="50%" valign="top">

### 🛠️ One-click install & revert
- Installs DLLs and generates configs for **SmokeAPI**, **CreamAPI**, **ScreamAPI**, **Uplay R1** & **Uplay R2** Unlockers, optionally through **Koaloader**
- Cleanly **uninstalls** all of the above
- Repairs the **Paradox Launcher** automatically after launcher updates

</td>
</tr>
<tr>
<td width="50%" valign="top">

### 🎨 Comfort features
- 🌙 **Dark mode**
- 🔤 Sort the game list by name
- 🛡️ Block protected games
- 🧹 Clear the cache and reconfigure SteamCMD from **Settings**

</td>
<td width="50%" valign="top">

### 🧪 For tinkerers
- **Test Game Generator** for Steam / Epic / Ubisoft App IDs
- Debug log window
- Unlocker DLLs are embedded in the binary, so **nothing else needs to be downloaded**

</td>
</tr>
</table>

---

## 🎥 Act III — Lights, Camera, Install

### 📦 Installation

```text
1. Download   →  CreamInstaller.zip from the latest release
2. Extract    →  CreamInstaller.exe, anywhere you like (single-file executable)
3. Run        →  that's it
```

<div align="center">

[![Download](https://img.shields.io/badge/⬇%20Download-Latest%20Release-ff8a00?style=for-the-badge&logo=github)](https://github.com/ubden/CreamApi-CreamInstaller/releases/latest)
[![.NET Runtime](https://img.shields.io/badge/Requires-.NET%209%20Desktop%20Runtime%20(x64)-512BD4?style=for-the-badge&logo=dotnet)](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)

</div>

> [!IMPORTANT]
> CreamInstaller ships as a single executable, but it **depends on the [.NET 9 Desktop Runtime (x64)](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)**. If the program doesn't launch, install that runtime first.

### 🎬 Usage: the scene-by-scene script

| Scene | Action |
|:---:|---|
| **1** | Launch `CreamInstaller.exe`. *(See above if it doesn't start.)* |
| **2** | Choose which programs and games to scan. *All installed Steam, Epic and Ubisoft games are detected automatically.* |
| **3** | If you picked a Steam game, wait while SteamCMD is downloaded and installed. *Usually quick; depends on your connection.* |
| **4** | Wait while game info and DLCs are gathered and cached. *The first run can take a while if you selected many games with many DLCs.* |
| **5** | **CAREFULLY** select the games and DLCs you want to unlock. *No unlocker has been tested on every game.* |
| **6** | Decide whether to use **Koaloader**, and if so, choose a proxy DLL. *If the default `version.dll` doesn't work, see the [forum thread](https://forum.ubden.com/konu/creaminstaller-auto-dlc-unlocker-installer-config-gen.1602/).* |
| **7** | Click **Generate and Install**. 🎉 |
| **8** | Click **OK** to close the program. |
| **↩️** | If an unlocker causes trouble, return to scene 5, select the games to revert, and click **Uninstall Selected**. |

> [!NOTE]
> CreamInstaller does **not** download or install actual DLC content. It installs DLC *unlockers* only. If a game doesn't already ship with its DLC files (many don't), you'll need to get them yourself. The relevant cs.rin.ru thread for the game is usually the best place to look.

---

## 🧰 Act IV — Behind the Scenes

<details>
<summary><b>🏗️ Building from source</b></summary>

<br/>

**Requirements**
- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later (SDK 10.x also works: `global.json` uses `rollForward: latestMajor`)
- Visual Studio 2022+ with the *.NET desktop development* workload, **or** VS Code with the C# extension

```bash
git clone https://github.com/ubden/CreamApi-CreamInstaller.git
cd CreamApi-CreamInstaller
dotnet build CreamInstaller/CreamInstaller.csproj -c Release
```

**Publishing a single-file build** (the same command the release workflow runs):

```bash
dotnet publish CreamInstaller/CreamInstaller.csproj -c Release -r win-x64 \
  --self-contained false -p:PublishSingleFile=true -o publish/
```

> CreamAPI's `steam_api.dll` / `steam_api64.dll` are **not** distributed in this repository. To embed CreamAPI, place them in `CreamInstaller/Resources/CreamAPI/` before building. Without them the build still succeeds, but the CreamAPI unlocker option is unavailable in that build. Use a CreamAPI release whose MD5 hashes appear in `ResourceMD5s` in `CreamInstaller/Resources/CreamAPI.cs` (v2.0.0.3 – v5.3.0.0), or add the new hashes there with `Hashing/GetHashes.ps1`. Otherwise the installer won't recognize its own proxy DLLs.

</details>

<details>
<summary><b>🗺️ Project map</b></summary>

<br/>

```text
CreamInstaller/
├── Components/   → Custom WinForms controls (tree view, toggle switch, context menus)
├── Forms/        → Main, Install, Settings, Update, Debug, Scan & Test Game windows
├── Platforms/    → Steam (SteamCMD / Store / VDF), Epic (+ Heroic, GraphQL), Ubisoft, Paradox
├── Resources/    → Unlocker integrations + embedded DLLs (Koaloader, SmokeAPI, ScreamAPI, Uplay R1/R2, CreamAPI)
└── Utility/      → HTTP, caching, safe I/O, theming, logging, diagnostics
```

</details>

<details>
<summary><b>🐛 Bugs, crashes & questions</b></summary>

<br/>

Report bugs and crashes on the [**GitHub Issues**](https://github.com/ubden/CreamApi-CreamInstaller/issues) page for the fastest help.

> [!WARNING]
> **No official support is provided.** For community help, use:
> - 💬 [GitHub Discussions](https://github.com/ubden/CreamApi-CreamInstaller/discussions)
> - 🗣️ [ubden Forum](https://forum.ubden.com/konu/creaminstaller-auto-dlc-unlocker-installer-config-gen.1602/)

Want to contribute? Read the [Contributing Guide](.github/CONTRIBUTING.md) first.

</details>

---

## ⚖️ Act V — The Fine Print

> **This software is an open-source project developed for the community and is not affiliated with any organization or institution.**
> It is shared purely for **educational purposes**, software development testing, and to help the open-source community grow.

<details open>
<summary><b>🛡️ Antivirus / false-positive warning</b></summary>

<br/>

> ⚠️ **Software that modifies or interacts with DLL files is commonly flagged by antivirus programs.**

VirusTotal and antivirus software **may detect this project as malicious**. However:

- The **entire project is open source**. There is no encrypted or obfuscated code.
- It is intended solely for **educational and development purposes**.
- It is **for experienced users only**. If you aren't comfortable reviewing the source code yourself, **don't download or use this software**.

Further reading on antivirus false positives related to DLL-interacting tools:
📄 [Springer – *International Journal of Information Security* (2024)](https://link.springer.com/article/10.1007/s10207-024-00836-w) ·
📖 [Wikipedia – Antivirus Software](https://en.wikipedia.org/wiki/Antivirus_software)

</details>

<details open>
<summary><b>⚖️ Legal responsibility</b></summary>

<br/>

By using this software, you agree that:
- **All responsibility lies with you, the user.**
- The platform and its contributors provide this software **"as is"**, without warranty of any kind, express or implied, including but not limited to the warranties of **merchantability**, **fitness for a particular purpose**, or **non-infringement**.

> ⚠️ **Use it at your own risk.**

</details>

<details open>
<summary><b>🎯 Intended use</b></summary>

<br/>

This project exists to:
- Teach the community by sharing open-source code.
- Support learning and innovation through open collaboration.

❌ **This software is not intended for production use.** We strongly recommend buying properly licensed software for your needs.

</details>

<details open>
<summary><b>🚨 Report abuse</b></summary>

<br/>

If you see this software being abused or misused, report it to 📧 **[abuse@ubden.com](mailto:abuse@ubden.com)**.
Security vulnerabilities: see the [Security Policy](.github/SECURITY.md).

</details>

---

## 🎞️ End Credits

<div align="center">

*Starring the brilliant unlockers by* [**acidicoala**](https://github.com/acidicoala)

[Koaloader](https://github.com/acidicoala/Koaloader) · [SmokeAPI](https://github.com/acidicoala/SmokeAPI) · [ScreamAPI](https://github.com/acidicoala/ScreamAPI) · [Uplay R1 Unlocker](https://github.com/acidicoala/UplayR1Unlocker) · [Uplay R2 Unlocker](https://github.com/acidicoala/UplayR2Unlocker)

*Their latest versions are embedded in the program, so you don't need to download anything else.*

<br/>

*With thanks to everyone who has ever opened an issue, sent a PR, or helped someone on the forum.*

<a href="https://github.com/ubden/CreamApi-CreamInstaller/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ubden/CreamApi-CreamInstaller" alt="Contributors" />
</a>

</div>

---

## 🌟 Post-Credits Scene — Join the Cast

<div align="center">

### *Every hit movie needs a sequel. Every sequel needs a crew.*

This project is built and maintained **for free**, on nights and weekends, for a community of gamers and tinkerers.
Following, starring and donating keep the next release coming.

<br/>

<table>
<tr>
<td align="center" width="33%">

### 👤 Follow

Get notified about new releases and new projects first.

<a href="https://github.com/ubden"><img src="https://img.shields.io/badge/Follow-@ubden-181717?style=for-the-badge&logo=github" alt="Follow @ubden" /></a>

</td>
<td align="center" width="33%">

### ⭐ Star

It costs nothing and helps others discover the project.

<a href="https://github.com/ubden/CreamApi-CreamInstaller/stargazers"><img src="https://img.shields.io/badge/Star-This%20Repo-f5c518?style=for-the-badge&logo=github&logoColor=black" alt="Star this repo" /></a>

</td>
<td align="center" width="33%">

### ☕ Donate

Every donation turns into more updates, fixes and supported games.

<a href="https://ubd.one/donate"><img src="https://img.shields.io/badge/Donate-Support%20Us-ff5f5f?style=for-the-badge&logo=paypal&logoColor=white" alt="Donate" /></a>

</td>
</tr>
</table>

<br/>

**More ways to support:**

<a href="https://github.com/sponsors/ubden"><img src="https://img.shields.io/badge/GitHub%20Sponsors-EA4AAA?style=flat-square&logo=githubsponsors&logoColor=white" alt="GitHub Sponsors" /></a>
<a href="https://buymeacoffee.com/ubden"><img src="https://img.shields.io/badge/Buy%20Me%20a%20Coffee-FFDD00?style=flat-square&logo=buymeacoffee&logoColor=black" alt="Buy Me a Coffee" /></a>
<a href="https://ko-fi.com/ubden"><img src="https://img.shields.io/badge/Ko--fi-FF5E5B?style=flat-square&logo=kofi&logoColor=white" alt="Ko-fi" /></a>
<a href="https://www.patreon.com/ubden"><img src="https://img.shields.io/badge/Patreon-F96854?style=flat-square&logo=patreon&logoColor=white" alt="Patreon" /></a>
<a href="https://opencollective.com/ubden"><img src="https://img.shields.io/badge/Open%20Collective-7FADF2?style=flat-square&logo=opencollective&logoColor=white" alt="Open Collective" /></a>
<a href="https://liberapay.com/ubden"><img src="https://img.shields.io/badge/Liberapay-F6C915?style=flat-square&logo=liberapay&logoColor=black" alt="Liberapay" /></a>

<br/><br/>

### 📈 The story so far

<a href="https://star-history.com/#ubden/CreamApi-CreamInstaller&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=ubden/CreamApi-CreamInstaller&type=Date&theme=dark" />
    <img src="https://api.star-history.com/svg?repos=ubden/CreamApi-CreamInstaller&type=Date" width="640" alt="Star History" />
  </picture>
</a>

<br/><br/>

> *"The end? No. This is only the beginning."* 🎬
> **Thank you for being part of the open-source community.** 🌟

<img src="https://capsule-render.vercel.app/api?type=waving&color=0:ff8a00,50:302b63,100:0f0c29&height=120&section=footer" width="100%" alt="" />

</div>
