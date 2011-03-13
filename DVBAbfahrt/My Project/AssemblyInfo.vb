Imports System
Imports System.Reflection
Imports System.Runtime.InteropServices

' Allgemeine Informationen über eine Assembly werden über die folgenden
' Attribute gesteuert. Ändern Sie diese Attributwerte, um die Informationen zu ändern,
' die mit einer Assembly verknüpft sind.

' Die Werte der Assemblyattribute überprüfen

<Assembly: AssemblyTitle("DVBAbfahrt")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyCompany("")> 
<Assembly: AssemblyProduct("DVBAbfahrt")>
<Assembly: AssemblyCopyright("Copyright © Martin Schmidt 2011")> 
<Assembly: AssemblyTrademark("")>

<Assembly: CLSCompliant(True)>

<Assembly: ComVisible(False)>

'Die folgende GUID bestimmt die ID der Typbibliothek, wenn dieses Projekt für COM verfügbar gemacht wird
<Assembly: Guid("d72d4336-8f11-4571-88b1-79d55ae96387")>

' Versionsinformationen für eine Assembly bestehen aus den folgenden vier Werten:
'
'      Hauptversion
'      Nebenversion
'      Buildnummer
'      Revision
'
' Sie können alle Werte angeben oder die standardmäßigen Build- und Revisionsnummern
' übernehmen, indem Sie "*" eingeben:
' <Assembly: AssemblyVersion("1.0.*")>

<Assembly: AssemblyVersion("0.8.1.1")> 

'Mit dem nachstehenden Attribut wird die FxCop-Warnung "CA2232 : Microsoft.Usage : Fügen Sie ein STAThreadAttribute zu der Assembly hinzu" unterdrückt,
' da die Geräteanwendung keine STA-Threads unterstützt.
<Assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2232:MarkWindowsFormsEntryPointsWithStaThread")>
