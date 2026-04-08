---
name: Antivirus False Positive Report
about: Report an antivirus false positive detection (Mamson.A!ac, Phonzy.A!ml, Wacatac.H!ml, Malgent!MSR, etc.)
title: '[False Positive] '
labels: 'false-positive'
assignees: ''

---

> 🛡️ **Antivirus false positives are expected and well-known for this type of software.**

This project interacts with DLL files, which causes antivirus programs to flag it as suspicious. This is a **false positive**. The entire source code is open and available for review.

**Before posting, please note:**
- The entire project is **open source** — no obfuscated or encrypted code exists.
- Detections such as `Mamson.A!ac`, `Phonzy.A!ml`, `Wacatac.H!ml`, `Malgent!MSR` are common false positives for DLL-interacting tools.
- This is documented in [Springer – International Journal of Information Security (2024)](https://link.springer.com/article/10.1007/s10207-024-00836-w).

**Community discussion:**
- [GitHub Discussions](https://github.com/ubden/CreamApi-CreamInstaller/discussions)
- [ubden Forum](https://forum.ubden.com.tr/konu/creaminstaller-auto-dlc-unlocker-installer-config-gen.1602/)

---

#### Antivirus software name and version
Windows Defender and other antivirus programs

#### Detection name(s)
Mamson.A!ac, Trojan:Win32/ and other

#### File(s) flagged
Please review code line : "// ANTIVIRUS FALSE POSITIVE WARNING:" and folder /Resourcues

#### VirusTotal link (optional)
Check comments : https://github.com/ubden/CreamApi-CreamInstaller/discussions
