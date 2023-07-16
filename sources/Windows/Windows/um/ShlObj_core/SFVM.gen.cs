// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class SFVM
{
    [NativeTypeName("#define SFVM_MERGEMENU 1")]
    public const int SFVM_MERGEMENU = 1;
    [NativeTypeName("#define SFVM_INVOKECOMMAND 2")]
    public const int SFVM_INVOKECOMMAND = 2;
    [NativeTypeName("#define SFVM_GETHELPTEXT 3")]
    public const int SFVM_GETHELPTEXT = 3;
    [NativeTypeName("#define SFVM_GETTOOLTIPTEXT 4")]
    public const int SFVM_GETTOOLTIPTEXT = 4;
    [NativeTypeName("#define SFVM_GETBUTTONINFO 5")]
    public const int SFVM_GETBUTTONINFO = 5;
    [NativeTypeName("#define SFVM_GETBUTTONS 6")]
    public const int SFVM_GETBUTTONS = 6;
    [NativeTypeName("#define SFVM_INITMENUPOPUP 7")]
    public const int SFVM_INITMENUPOPUP = 7;
    [NativeTypeName("#define SFVM_FSNOTIFY 14")]
    public const int SFVM_FSNOTIFY = 14;
    [NativeTypeName("#define SFVM_WINDOWCREATED 15")]
    public const int SFVM_WINDOWCREATED = 15;
    [NativeTypeName("#define SFVM_GETDETAILSOF 23")]
    public const int SFVM_GETDETAILSOF = 23;
    [NativeTypeName("#define SFVM_COLUMNCLICK 24")]
    public const int SFVM_COLUMNCLICK = 24;
    [NativeTypeName("#define SFVM_QUERYFSNOTIFY 25")]
    public const int SFVM_QUERYFSNOTIFY = 25;
    [NativeTypeName("#define SFVM_DEFITEMCOUNT 26")]
    public const int SFVM_DEFITEMCOUNT = 26;
    [NativeTypeName("#define SFVM_DEFVIEWMODE 27")]
    public const int SFVM_DEFVIEWMODE = 27;
    [NativeTypeName("#define SFVM_UNMERGEMENU 28")]
    public const int SFVM_UNMERGEMENU = 28;
    [NativeTypeName("#define SFVM_UPDATESTATUSBAR 31")]
    public const int SFVM_UPDATESTATUSBAR = 31;
    [NativeTypeName("#define SFVM_BACKGROUNDENUM 32")]
    public const int SFVM_BACKGROUNDENUM = 32;
    [NativeTypeName("#define SFVM_DIDDRAGDROP 36")]
    public const int SFVM_DIDDRAGDROP = 36;
    [NativeTypeName("#define SFVM_SETISFV 39")]
    public const int SFVM_SETISFV = 39;
    [NativeTypeName("#define SFVM_THISIDLIST 41")]
    public const int SFVM_THISIDLIST = 41;
    [NativeTypeName("#define SFVM_ADDPROPERTYPAGES 47")]
    public const int SFVM_ADDPROPERTYPAGES = 47;
    [NativeTypeName("#define SFVM_BACKGROUNDENUMDONE 48")]
    public const int SFVM_BACKGROUNDENUMDONE = 48;
    [NativeTypeName("#define SFVM_GETNOTIFY 49")]
    public const int SFVM_GETNOTIFY = 49;
    [NativeTypeName("#define SFVM_GETSORTDEFAULTS 53")]
    public const int SFVM_GETSORTDEFAULTS = 53;
    [NativeTypeName("#define SFVM_SIZE 57")]
    public const int SFVM_SIZE = 57;
    [NativeTypeName("#define SFVM_GETZONE 58")]
    public const int SFVM_GETZONE = 58;
    [NativeTypeName("#define SFVM_GETPANE 59")]
    public const int SFVM_GETPANE = 59;
    [NativeTypeName("#define SFVM_GETHELPTOPIC 63")]
    public const int SFVM_GETHELPTOPIC = 63;
    [NativeTypeName("#define SFVM_GETANIMATION 68")]
    public const int SFVM_GETANIMATION = 68;
}