# Coding standard application

Source: `EstandarTecnologias-Equipo 4.pdf`, supplied by the user.
Scope: the configuration prototype, its host window, shared styles, and localization resources.

| Standard section | Application |
| --- | --- |
| 1.3, 4 | English identifiers and comments; descriptive names with the required casing. |
| 4.4.1 | Explicit local variable types; no `var` in authored C# files. |
| 4.5 | Private control fields use `_camelCase` and `x:FieldModifier="private"`. |
| 4.7, 8.1 | Named constants define initial volume levels, limits, and increments. |
| 5.1, 5.2 | Four spaces, Allman braces, one statement per line, and at most 120 columns. |
| 5.3 | File-scoped namespaces, one public type per file, and explicit ordered imports. |
| 5.4 | Constructors appear before methods; constants are grouped at the start of their type. |
| 10 | Comments explain non-obvious framework constraints in English. |
| 10.3 | No redundant XML documentation on view classes; no public service was introduced. |
| 12.3 | All player-facing strings use `.resx` files and the automatically generated `UiStrings` class. |

## Window responsibilities

`MainWindow` is the startup window. Its only navigation handler opens `SettingsWindow` as an owned modal window.
`SettingsWindow` contains the supplied graphical design. Its code-behind only initializes the view.
Its Back and Save buttons have no handlers or application commands.
The language options use two-way bindings to the shared `LocalizationViewModel`.
Changing the selected option refreshes translated text in both windows through `INotifyPropertyChanged`.
The selected language lasts for the current session and is restored when the settings window is reopened.
Changing the language does not recreate the view or reset its volume controls.

## Generated code and framework conventions

MSBuild generates `UiStrings.g.cs` under `obj`; the generated class is not manually maintained or versioned.
The standard's authored-code formatting rules are not applied to compiler-generated files or third-party licenses.
WPF requires the `PART_Track` template name. The corresponding XAML comment documents that framework requirement.
Other template names describe visual parts and are scoped to their templates; they do not generate view fields.

The slider templates use WPF's built-in `DecreaseLarge` and `IncreaseLarge` commands only for visual interaction.
Layout sizes, grid indices, and vector geometry coordinates remain declarative design values in XAML.
No gameplay thresholds or other domain rules are embedded in the layout.

## Resource generation

The project generates the resource class before WPF compiles references to local types.
The generated file is registered for both the temporary WPF assembly and the final assembly.
Spanish is the neutral language; English translations are embedded in the `en` satellite assembly.
The view model reads translated values from the generated `UiStrings.ResourceManager`.
No duplicate translation dictionary or additional resource-generation package is needed.

## Scope boundaries

No persistence, networking, logging, domain services, or gameplay logic was added.
The standard's requirements for those components become applicable when such components are implemented.
The requested graphical scope does not require placeholder services, empty exception handlers, or artificial unit tests.
