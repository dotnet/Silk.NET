// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class CFSTR
{
    [NativeTypeName("#define CFSTR_SHELLIDLIST TEXT(\"Shell IDList Array\")")]
    public const string CFSTR_SHELLIDLIST = "Shell IDList Array";
    [NativeTypeName("#define CFSTR_SHELLIDLISTOFFSET TEXT(\"Shell Object Offsets\")")]
    public const string CFSTR_SHELLIDLISTOFFSET = "Shell Object Offsets";
    [NativeTypeName("#define CFSTR_NETRESOURCES TEXT(\"Net Resource\")")]
    public const string CFSTR_NETRESOURCES = "Net Resource";
    [NativeTypeName("#define CFSTR_FILEDESCRIPTORA TEXT(\"FileGroupDescriptor\")")]
    public const string CFSTR_FILEDESCRIPTORA = "FileGroupDescriptor";
    [NativeTypeName("#define CFSTR_FILEDESCRIPTORW TEXT(\"FileGroupDescriptorW\")")]
    public const string CFSTR_FILEDESCRIPTORW = "FileGroupDescriptorW";
    [NativeTypeName("#define CFSTR_FILECONTENTS TEXT(\"FileContents\")")]
    public const string CFSTR_FILECONTENTS = "FileContents";
    [NativeTypeName("#define CFSTR_FILENAMEA TEXT(\"FileName\")")]
    public const string CFSTR_FILENAMEA = "FileName";
    [NativeTypeName("#define CFSTR_FILENAMEW TEXT(\"FileNameW\")")]
    public const string CFSTR_FILENAMEW = "FileNameW";
    [NativeTypeName("#define CFSTR_PRINTERGROUP TEXT(\"PrinterFriendlyName\")")]
    public const string CFSTR_PRINTERGROUP = "PrinterFriendlyName";
    [NativeTypeName("#define CFSTR_FILENAMEMAPA TEXT(\"FileNameMap\")")]
    public const string CFSTR_FILENAMEMAPA = "FileNameMap";
    [NativeTypeName("#define CFSTR_FILENAMEMAPW TEXT(\"FileNameMapW\")")]
    public const string CFSTR_FILENAMEMAPW = "FileNameMapW";
    [NativeTypeName("#define CFSTR_SHELLURL TEXT(\"UniformResourceLocator\")")]
    public const string CFSTR_SHELLURL = "UniformResourceLocator";
    [NativeTypeName("#define CFSTR_INETURLA CFSTR_SHELLURL")]
    public const string CFSTR_INETURLA = "UniformResourceLocator";
    [NativeTypeName("#define CFSTR_INETURLW TEXT(\"UniformResourceLocatorW\")")]
    public const string CFSTR_INETURLW = "UniformResourceLocatorW";
    [NativeTypeName("#define CFSTR_PREFERREDDROPEFFECT TEXT(\"Preferred DropEffect\")")]
    public const string CFSTR_PREFERREDDROPEFFECT = "Preferred DropEffect";
    [NativeTypeName("#define CFSTR_PERFORMEDDROPEFFECT TEXT(\"Performed DropEffect\")")]
    public const string CFSTR_PERFORMEDDROPEFFECT = "Performed DropEffect";
    [NativeTypeName("#define CFSTR_PASTESUCCEEDED TEXT(\"Paste Succeeded\")")]
    public const string CFSTR_PASTESUCCEEDED = "Paste Succeeded";
    [NativeTypeName("#define CFSTR_INDRAGLOOP TEXT(\"InShellDragLoop\")")]
    public const string CFSTR_INDRAGLOOP = "InShellDragLoop";
    [NativeTypeName("#define CFSTR_MOUNTEDVOLUME TEXT(\"MountedVolume\")")]
    public const string CFSTR_MOUNTEDVOLUME = "MountedVolume";
    [NativeTypeName("#define CFSTR_PERSISTEDDATAOBJECT TEXT(\"PersistedDataObject\")")]
    public const string CFSTR_PERSISTEDDATAOBJECT = "PersistedDataObject";
    [NativeTypeName("#define CFSTR_TARGETCLSID TEXT(\"TargetCLSID\")")]
    public const string CFSTR_TARGETCLSID = "TargetCLSID";
    [NativeTypeName("#define CFSTR_LOGICALPERFORMEDDROPEFFECT TEXT(\"Logical Performed DropEffect\")")]
    public const string CFSTR_LOGICALPERFORMEDDROPEFFECT = "Logical Performed DropEffect";
    [NativeTypeName("#define CFSTR_AUTOPLAY_SHELLIDLISTS TEXT(\"Autoplay Enumerated IDList Array\")")]
    public const string CFSTR_AUTOPLAY_SHELLIDLISTS = "Autoplay Enumerated IDList Array";
    [NativeTypeName("#define CFSTR_UNTRUSTEDDRAGDROP TEXT(\"UntrustedDragDrop\")")]
    public const string CFSTR_UNTRUSTEDDRAGDROP = "UntrustedDragDrop";
    [NativeTypeName("#define CFSTR_FILE_ATTRIBUTES_ARRAY TEXT(\"File Attributes Array\")")]
    public const string CFSTR_FILE_ATTRIBUTES_ARRAY = "File Attributes Array";
    [NativeTypeName("#define CFSTR_INVOKECOMMAND_DROPPARAM TEXT(\"InvokeCommand DropParam\")")]
    public const string CFSTR_INVOKECOMMAND_DROPPARAM = "InvokeCommand DropParam";
    [NativeTypeName("#define CFSTR_SHELLDROPHANDLER TEXT(\"DropHandlerCLSID\")")]
    public const string CFSTR_SHELLDROPHANDLER = "DropHandlerCLSID";
    [NativeTypeName("#define CFSTR_DROPDESCRIPTION TEXT(\"DropDescription\")")]
    public const string CFSTR_DROPDESCRIPTION = "DropDescription";
    [NativeTypeName("#define CFSTR_ZONEIDENTIFIER TEXT(\"ZoneIdentifier\")")]
    public const string CFSTR_ZONEIDENTIFIER = "ZoneIdentifier";
    [NativeTypeName("#define CFSTR_FILEDESCRIPTOR CFSTR_FILEDESCRIPTORW")]
    public const string CFSTR_FILEDESCRIPTOR = "FileGroupDescriptorW";
    [NativeTypeName("#define CFSTR_FILENAME CFSTR_FILENAMEW")]
    public const string CFSTR_FILENAME = "FileNameW";
    [NativeTypeName("#define CFSTR_FILENAMEMAP CFSTR_FILENAMEMAPW")]
    public const string CFSTR_FILENAMEMAP = "FileNameMapW";
    [NativeTypeName("#define CFSTR_INETURL CFSTR_INETURLW")]
    public const string CFSTR_INETURL = "UniformResourceLocatorW";
}