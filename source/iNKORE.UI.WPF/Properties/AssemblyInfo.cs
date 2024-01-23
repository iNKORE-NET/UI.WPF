using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Markup;

[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
                                     //(used if a resource is not found in the page,
                                     // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
                                              //(used if a resource is not found in the page,
                                              // app, or any theme specific resource dictionaries)
)]


[assembly: AssemblyTitle("iNKORE.UI.WPF")]
[assembly: AssemblyDescription("Some frequently-used modules and helpers for your WPF applications")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("iNKORE Studios")]
[assembly: AssemblyProduct("iNKORE.UI.WPF")]
[assembly: AssemblyCopyright("Copyright © iNKORE! 2023")]
[assembly: AssemblyTrademark("iNKORE!")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyCulture("")]

[assembly: XmlnsPrefix("http://schemas.inkore.net/lib/ui/wpf", "ikw")]
[assembly: XmlnsDefinition("http://schemas.inkore.net/lib/ui/wpf", "iNKORE.UI.WPF")]
[assembly: XmlnsDefinition("http://schemas.inkore.net/lib/ui/wpf", "iNKORE.UI.WPF.Converters")]
[assembly: XmlnsDefinition("http://schemas.inkore.net/lib/ui/wpf", "iNKORE.UI.WPF.Controls")]
[assembly: XmlnsDefinition("http://schemas.inkore.net/lib/ui/wpf", "iNKORE.UI.WPF.ColorPicker")]
[assembly: XmlnsDefinition("http://schemas.inkore.net/lib/ui/wpf", "iNKORE.UI.WPF.TrayIconss")]
[assembly: XmlnsDefinition("http://schemas.inkore.net/lib/ui/wpf", "iNKORE.UI.WPF.DragDrop")]
