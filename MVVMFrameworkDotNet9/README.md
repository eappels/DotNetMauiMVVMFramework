MVVMFrameworkDotNet9
====================

Summary
-------
This solution is a minimal .NET MAUI demo app that illustrates a small MVVM architecture using modern .NET 9 tooling. It contains a simple UI (DemoView) bound to a ViewModel (DemoViewModel) which calls a lightweight service (DemoService) via an interface (IDemoService). The app demonstrates dependency injection, resource-driven styling, and Shell-based navigation.

Technologies & Libraries
-----------------------
- .NET 9 (multi-targeted MAUI single project)
- .NET MAUI — cross-platform UI framework (Android, iOS, MacCatalyst, Windows)
- CommunityToolkit.Mvvm — source-generated observable properties and relay commands
- Microsoft.Extensions.DependencyInjection — DI container registration in `MauiProgram`
- Microsoft.Extensions.Logging.Debug — debug logging provider
- XAML resource dictionaries — `Resources/Styles/Colors.xaml`, `Resources/Styles/Styles.xaml`
- MAUI single-project assets: fonts, images, icons and splash configured via the project file

Key Project Concepts
--------------------
- MVVM pattern:
  - Views: `Views/DemoView.xaml` (ContentPage with compiled bindings `x:DataType`)
  - ViewModels: `ViewModels/DemoViewModel.cs` (uses `[ObservableProperty]` and `[RelayCommand]`)
  - Services: `Services/DemoService.cs` implements `Interfaces/IDemoService.cs`
- Dependency Injection: views and viewmodels registered in `MauiProgram.cs` and resolved at runtime
- Shell-based navigation: `AppShell.xaml` defines top-level app navigation
- Styling: centralized colors and control styles in `Resources/Styles/*.xaml`
- Async/Command handling: CommunityToolkit generated async command (`TestMethodCommand`) used for safe async operations and UI state (`IsBusy`)

Project Structure (important files)
----------------------------------
- `MauiProgram.cs` — app startup, DI, fonts and services configuration
- `App.xaml` / `AppShell.xaml` — application and navigation shell
- `Views/DemoView.xaml` (+ code-behind) — demo UI
- `ViewModels/DemoViewModel.cs` — demo viewmodel using CommunityToolkit.Mvvm
- `Services/DemoService.cs` — example async service
- `Interfaces/IDemoService.cs` — service interface
- `Resources/Styles/Colors.xaml` and `Resources/Styles/Styles.xaml` — theme and control styles
- `Resources/*` — images, fonts and splash assets
- `License.txt` — repository license (see `ReadMe.txt` or `License.txt` for details)

Build & Run
-----------
Prerequisites:
- .NET 9 SDK
- Visual Studio 2022 (or 2022 for Mac) with MAUI workload and platform tooling

Steps:
1. Open the solution in Visual Studio.
2. Restore NuGet packages.
3. Choose the target platform (Android, iOS, MacCatalyst, or Windows).
4. Build and Run (F5). The demo view is exposed via the Shell.

Notes & Recommendations
-----------------------
- CommunityToolkit.Mvvm is used for productivity and compile-time generation; keep the package updated for improvements.
- For production apps, add logging (`ILogger<T>`), error handling, and unit tests for viewmodels and services.
- Consider adding cancellation tokens to long-running operations and more comprehensive accessibility attributes in XAML.

License
-------
See `License.txt` for the project license.
