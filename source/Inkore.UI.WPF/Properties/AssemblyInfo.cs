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


[assembly: AssemblyTitle("Inkore.UI.WPF")]
[assembly: AssemblyDescription("WPF components for iNKORE! products")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("iNKORE!")]
[assembly: AssemblyProduct("Inkore.UI.WPF")]
[assembly: AssemblyCopyright("Copyright © iNKORE! 2023")]
[assembly: AssemblyTrademark("iNKORE! Studios")]
[assembly: AssemblyVersion("0.1.0.0")]
[assembly: AssemblyCulture("")]

[assembly: XmlnsPrefix("http://schemas.inkore.net/lib/ui/wpf", "ikw")]
[assembly: XmlnsDefinition("http://schemas.inkore.net/lib/ui/wpf", "Inkore.UI.WPF")]
[assembly: XmlnsDefinition("http://schemas.inkore.net/lib/ui/wpf", "Inkore.UI.WPF.Converters")]
//[assembly: XmlnsDefinition("http://schemas.inkore.net/lib/ui/wpf", "Inkore.UI.WPF.Controls")]
//[assembly: XmlnsDefinition("http://schemas.inkore.net/lib/ui/wpf", "Inkore.UI.WPF.DragDrop")]
[assembly: XmlnsDefinition("http://schemas.inkore.net/lib/ui/wpf", "Inkore.UI.WPF.ColorPicker")]
[assembly: XmlnsDefinition("http://schemas.inkore.net/lib/ui/wpf", "Inkore.UI.WPF.TrayIcon")]
