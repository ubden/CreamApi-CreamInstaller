# Contributing to CreamInstaller

Thank you for your interest in contributing! This project is open-source and community-driven.

---

## ⚠️ Before You Start

- This project is for **educational purposes only**.
- By contributing, you agree your contributions are also educational in nature.
- Please read the [README](../README.md) and understand the project's scope.

---

## 🔧 Development Setup

### Requirements
- Windows 10/11 (x64)
- [.NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) or later
- Visual Studio 2022+ or VS Code with C# extension

### Build
```bash
git clone https://github.com/ubden-community/CreamApi-CreamInstaller.git
cd CreamApi-CreamInstaller
dotnet build CreamInstaller/CreamInstaller.csproj -c Debug
```

---

## 📋 How to Contribute

### Reporting Bugs
Use the [Bug Report](.github/ISSUE_TEMPLATE/bug-report.md) template.

### Suggesting Enhancements
Use the [Enhancement Request](.github/ISSUE_TEMPLATE/enhancement-request.md) template.

### Pull Requests

1. **Fork** the repository
2. **Create a branch**: `git checkout -b feature/my-feature`
3. **Make your changes** — keep them focused and minimal
4. **Format your code**: `dotnet format`
5. **Build and test** locally: `dotnet build -c Release`
6. **Commit** with a descriptive message
7. **Push** and open a Pull Request against `main`

### PR Guidelines
- Keep PRs small and focused — one feature or fix per PR
- Describe what changed and why in the PR description
- Ensure the CI build passes before requesting review
- Do not include binary files or DLLs in the PR

---

## 💬 Community

- [GitHub Discussions](https://github.com/ubden/CreamApi-CreamInstaller/discussions)
- [ubden Forum](https://forum.ubden.com.tr/konu/creaminstaller-auto-dlc-unlocker-installer-config-gen.1602/)

---

## 📜 License

By contributing, you agree that your contributions will be licensed under the [GPL v3](../LICENSE) license.
