// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class EVENT
{
    [NativeTypeName("#define EVENT_MIN 0x00000001")]
    public const int EVENT_MIN = 0x00000001;
    [NativeTypeName("#define EVENT_MAX 0x7FFFFFFF")]
    public const int EVENT_MAX = 0x7FFFFFFF;
    [NativeTypeName("#define EVENT_SYSTEM_SOUND 0x0001")]
    public const int EVENT_SYSTEM_SOUND = 0x0001;
    [NativeTypeName("#define EVENT_SYSTEM_ALERT 0x0002")]
    public const int EVENT_SYSTEM_ALERT = 0x0002;
    [NativeTypeName("#define EVENT_SYSTEM_FOREGROUND 0x0003")]
    public const int EVENT_SYSTEM_FOREGROUND = 0x0003;
    [NativeTypeName("#define EVENT_SYSTEM_MENUSTART 0x0004")]
    public const int EVENT_SYSTEM_MENUSTART = 0x0004;
    [NativeTypeName("#define EVENT_SYSTEM_MENUEND 0x0005")]
    public const int EVENT_SYSTEM_MENUEND = 0x0005;
    [NativeTypeName("#define EVENT_SYSTEM_MENUPOPUPSTART 0x0006")]
    public const int EVENT_SYSTEM_MENUPOPUPSTART = 0x0006;
    [NativeTypeName("#define EVENT_SYSTEM_MENUPOPUPEND 0x0007")]
    public const int EVENT_SYSTEM_MENUPOPUPEND = 0x0007;
    [NativeTypeName("#define EVENT_SYSTEM_CAPTURESTART 0x0008")]
    public const int EVENT_SYSTEM_CAPTURESTART = 0x0008;
    [NativeTypeName("#define EVENT_SYSTEM_CAPTUREEND 0x0009")]
    public const int EVENT_SYSTEM_CAPTUREEND = 0x0009;
    [NativeTypeName("#define EVENT_SYSTEM_MOVESIZESTART 0x000A")]
    public const int EVENT_SYSTEM_MOVESIZESTART = 0x000A;
    [NativeTypeName("#define EVENT_SYSTEM_MOVESIZEEND 0x000B")]
    public const int EVENT_SYSTEM_MOVESIZEEND = 0x000B;
    [NativeTypeName("#define EVENT_SYSTEM_CONTEXTHELPSTART 0x000C")]
    public const int EVENT_SYSTEM_CONTEXTHELPSTART = 0x000C;
    [NativeTypeName("#define EVENT_SYSTEM_CONTEXTHELPEND 0x000D")]
    public const int EVENT_SYSTEM_CONTEXTHELPEND = 0x000D;
    [NativeTypeName("#define EVENT_SYSTEM_DRAGDROPSTART 0x000E")]
    public const int EVENT_SYSTEM_DRAGDROPSTART = 0x000E;
    [NativeTypeName("#define EVENT_SYSTEM_DRAGDROPEND 0x000F")]
    public const int EVENT_SYSTEM_DRAGDROPEND = 0x000F;
    [NativeTypeName("#define EVENT_SYSTEM_DIALOGSTART 0x0010")]
    public const int EVENT_SYSTEM_DIALOGSTART = 0x0010;
    [NativeTypeName("#define EVENT_SYSTEM_DIALOGEND 0x0011")]
    public const int EVENT_SYSTEM_DIALOGEND = 0x0011;
    [NativeTypeName("#define EVENT_SYSTEM_SCROLLINGSTART 0x0012")]
    public const int EVENT_SYSTEM_SCROLLINGSTART = 0x0012;
    [NativeTypeName("#define EVENT_SYSTEM_SCROLLINGEND 0x0013")]
    public const int EVENT_SYSTEM_SCROLLINGEND = 0x0013;
    [NativeTypeName("#define EVENT_SYSTEM_SWITCHSTART 0x0014")]
    public const int EVENT_SYSTEM_SWITCHSTART = 0x0014;
    [NativeTypeName("#define EVENT_SYSTEM_SWITCHEND 0x0015")]
    public const int EVENT_SYSTEM_SWITCHEND = 0x0015;
    [NativeTypeName("#define EVENT_SYSTEM_MINIMIZESTART 0x0016")]
    public const int EVENT_SYSTEM_MINIMIZESTART = 0x0016;
    [NativeTypeName("#define EVENT_SYSTEM_MINIMIZEEND 0x0017")]
    public const int EVENT_SYSTEM_MINIMIZEEND = 0x0017;
    [NativeTypeName("#define EVENT_SYSTEM_DESKTOPSWITCH 0x0020")]
    public const int EVENT_SYSTEM_DESKTOPSWITCH = 0x0020;
    [NativeTypeName("#define EVENT_SYSTEM_SWITCHER_APPGRABBED 0x0024")]
    public const int EVENT_SYSTEM_SWITCHER_APPGRABBED = 0x0024;
    [NativeTypeName("#define EVENT_SYSTEM_SWITCHER_APPOVERTARGET 0x0025")]
    public const int EVENT_SYSTEM_SWITCHER_APPOVERTARGET = 0x0025;
    [NativeTypeName("#define EVENT_SYSTEM_SWITCHER_APPDROPPED 0x0026")]
    public const int EVENT_SYSTEM_SWITCHER_APPDROPPED = 0x0026;
    [NativeTypeName("#define EVENT_SYSTEM_SWITCHER_CANCELLED 0x0027")]
    public const int EVENT_SYSTEM_SWITCHER_CANCELLED = 0x0027;
    [NativeTypeName("#define EVENT_SYSTEM_IME_KEY_NOTIFICATION 0x0029")]
    public const int EVENT_SYSTEM_IME_KEY_NOTIFICATION = 0x0029;
    [NativeTypeName("#define EVENT_SYSTEM_END 0x00FF")]
    public const int EVENT_SYSTEM_END = 0x00FF;
    [NativeTypeName("#define EVENT_OEM_DEFINED_START 0x0101")]
    public const int EVENT_OEM_DEFINED_START = 0x0101;
    [NativeTypeName("#define EVENT_OEM_DEFINED_END 0x01FF")]
    public const int EVENT_OEM_DEFINED_END = 0x01FF;
    [NativeTypeName("#define EVENT_UIA_EVENTID_START 0x4E00")]
    public const int EVENT_UIA_EVENTID_START = 0x4E00;
    [NativeTypeName("#define EVENT_UIA_EVENTID_END 0x4EFF")]
    public const int EVENT_UIA_EVENTID_END = 0x4EFF;
    [NativeTypeName("#define EVENT_UIA_PROPID_START 0x7500")]
    public const int EVENT_UIA_PROPID_START = 0x7500;
    [NativeTypeName("#define EVENT_UIA_PROPID_END 0x75FF")]
    public const int EVENT_UIA_PROPID_END = 0x75FF;
    [NativeTypeName("#define EVENT_CONSOLE_CARET 0x4001")]
    public const int EVENT_CONSOLE_CARET = 0x4001;
    [NativeTypeName("#define EVENT_CONSOLE_UPDATE_REGION 0x4002")]
    public const int EVENT_CONSOLE_UPDATE_REGION = 0x4002;
    [NativeTypeName("#define EVENT_CONSOLE_UPDATE_SIMPLE 0x4003")]
    public const int EVENT_CONSOLE_UPDATE_SIMPLE = 0x4003;
    [NativeTypeName("#define EVENT_CONSOLE_UPDATE_SCROLL 0x4004")]
    public const int EVENT_CONSOLE_UPDATE_SCROLL = 0x4004;
    [NativeTypeName("#define EVENT_CONSOLE_LAYOUT 0x4005")]
    public const int EVENT_CONSOLE_LAYOUT = 0x4005;
    [NativeTypeName("#define EVENT_CONSOLE_START_APPLICATION 0x4006")]
    public const int EVENT_CONSOLE_START_APPLICATION = 0x4006;
    [NativeTypeName("#define EVENT_CONSOLE_END_APPLICATION 0x4007")]
    public const int EVENT_CONSOLE_END_APPLICATION = 0x4007;
    [NativeTypeName("#define EVENT_CONSOLE_END 0x40FF")]
    public const int EVENT_CONSOLE_END = 0x40FF;
    [NativeTypeName("#define EVENT_OBJECT_CREATE 0x8000")]
    public const int EVENT_OBJECT_CREATE = 0x8000;
    [NativeTypeName("#define EVENT_OBJECT_DESTROY 0x8001")]
    public const int EVENT_OBJECT_DESTROY = 0x8001;
    [NativeTypeName("#define EVENT_OBJECT_SHOW 0x8002")]
    public const int EVENT_OBJECT_SHOW = 0x8002;
    [NativeTypeName("#define EVENT_OBJECT_HIDE 0x8003")]
    public const int EVENT_OBJECT_HIDE = 0x8003;
    [NativeTypeName("#define EVENT_OBJECT_REORDER 0x8004")]
    public const int EVENT_OBJECT_REORDER = 0x8004;
    [NativeTypeName("#define EVENT_OBJECT_FOCUS 0x8005")]
    public const int EVENT_OBJECT_FOCUS = 0x8005;
    [NativeTypeName("#define EVENT_OBJECT_SELECTION 0x8006")]
    public const int EVENT_OBJECT_SELECTION = 0x8006;
    [NativeTypeName("#define EVENT_OBJECT_SELECTIONADD 0x8007")]
    public const int EVENT_OBJECT_SELECTIONADD = 0x8007;
    [NativeTypeName("#define EVENT_OBJECT_SELECTIONREMOVE 0x8008")]
    public const int EVENT_OBJECT_SELECTIONREMOVE = 0x8008;
    [NativeTypeName("#define EVENT_OBJECT_SELECTIONWITHIN 0x8009")]
    public const int EVENT_OBJECT_SELECTIONWITHIN = 0x8009;
    [NativeTypeName("#define EVENT_OBJECT_STATECHANGE 0x800A")]
    public const int EVENT_OBJECT_STATECHANGE = 0x800A;
    [NativeTypeName("#define EVENT_OBJECT_LOCATIONCHANGE 0x800B")]
    public const int EVENT_OBJECT_LOCATIONCHANGE = 0x800B;
    [NativeTypeName("#define EVENT_OBJECT_NAMECHANGE 0x800C")]
    public const int EVENT_OBJECT_NAMECHANGE = 0x800C;
    [NativeTypeName("#define EVENT_OBJECT_DESCRIPTIONCHANGE 0x800D")]
    public const int EVENT_OBJECT_DESCRIPTIONCHANGE = 0x800D;
    [NativeTypeName("#define EVENT_OBJECT_VALUECHANGE 0x800E")]
    public const int EVENT_OBJECT_VALUECHANGE = 0x800E;
    [NativeTypeName("#define EVENT_OBJECT_PARENTCHANGE 0x800F")]
    public const int EVENT_OBJECT_PARENTCHANGE = 0x800F;
    [NativeTypeName("#define EVENT_OBJECT_HELPCHANGE 0x8010")]
    public const int EVENT_OBJECT_HELPCHANGE = 0x8010;
    [NativeTypeName("#define EVENT_OBJECT_DEFACTIONCHANGE 0x8011")]
    public const int EVENT_OBJECT_DEFACTIONCHANGE = 0x8011;
    [NativeTypeName("#define EVENT_OBJECT_ACCELERATORCHANGE 0x8012")]
    public const int EVENT_OBJECT_ACCELERATORCHANGE = 0x8012;
    [NativeTypeName("#define EVENT_OBJECT_INVOKED 0x8013")]
    public const int EVENT_OBJECT_INVOKED = 0x8013;
    [NativeTypeName("#define EVENT_OBJECT_TEXTSELECTIONCHANGED 0x8014")]
    public const int EVENT_OBJECT_TEXTSELECTIONCHANGED = 0x8014;
    [NativeTypeName("#define EVENT_OBJECT_CONTENTSCROLLED 0x8015")]
    public const int EVENT_OBJECT_CONTENTSCROLLED = 0x8015;
    [NativeTypeName("#define EVENT_SYSTEM_ARRANGMENTPREVIEW 0x8016")]
    public const int EVENT_SYSTEM_ARRANGMENTPREVIEW = 0x8016;
    [NativeTypeName("#define EVENT_OBJECT_CLOAKED 0x8017")]
    public const int EVENT_OBJECT_CLOAKED = 0x8017;
    [NativeTypeName("#define EVENT_OBJECT_UNCLOAKED 0x8018")]
    public const int EVENT_OBJECT_UNCLOAKED = 0x8018;
    [NativeTypeName("#define EVENT_OBJECT_LIVEREGIONCHANGED 0x8019")]
    public const int EVENT_OBJECT_LIVEREGIONCHANGED = 0x8019;
    [NativeTypeName("#define EVENT_OBJECT_HOSTEDOBJECTSINVALIDATED 0x8020")]
    public const int EVENT_OBJECT_HOSTEDOBJECTSINVALIDATED = 0x8020;
    [NativeTypeName("#define EVENT_OBJECT_DRAGSTART 0x8021")]
    public const int EVENT_OBJECT_DRAGSTART = 0x8021;
    [NativeTypeName("#define EVENT_OBJECT_DRAGCANCEL 0x8022")]
    public const int EVENT_OBJECT_DRAGCANCEL = 0x8022;
    [NativeTypeName("#define EVENT_OBJECT_DRAGCOMPLETE 0x8023")]
    public const int EVENT_OBJECT_DRAGCOMPLETE = 0x8023;
    [NativeTypeName("#define EVENT_OBJECT_DRAGENTER 0x8024")]
    public const int EVENT_OBJECT_DRAGENTER = 0x8024;
    [NativeTypeName("#define EVENT_OBJECT_DRAGLEAVE 0x8025")]
    public const int EVENT_OBJECT_DRAGLEAVE = 0x8025;
    [NativeTypeName("#define EVENT_OBJECT_DRAGDROPPED 0x8026")]
    public const int EVENT_OBJECT_DRAGDROPPED = 0x8026;
    [NativeTypeName("#define EVENT_OBJECT_IME_SHOW 0x8027")]
    public const int EVENT_OBJECT_IME_SHOW = 0x8027;
    [NativeTypeName("#define EVENT_OBJECT_IME_HIDE 0x8028")]
    public const int EVENT_OBJECT_IME_HIDE = 0x8028;
    [NativeTypeName("#define EVENT_OBJECT_IME_CHANGE 0x8029")]
    public const int EVENT_OBJECT_IME_CHANGE = 0x8029;
    [NativeTypeName("#define EVENT_OBJECT_TEXTEDIT_CONVERSIONTARGETCHANGED 0x8030")]
    public const int EVENT_OBJECT_TEXTEDIT_CONVERSIONTARGETCHANGED = 0x8030;
    [NativeTypeName("#define EVENT_OBJECT_END 0x80FF")]
    public const int EVENT_OBJECT_END = 0x80FF;
    [NativeTypeName("#define EVENT_AIA_START 0xA000")]
    public const int EVENT_AIA_START = 0xA000;
    [NativeTypeName("#define EVENT_AIA_END 0xAFFF")]
    public const int EVENT_AIA_END = 0xAFFF;
}