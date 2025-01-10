// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vsstyle.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum BUTTONPARTS
{
    BP_PUSHBUTTON = 1,
    BP_RADIOBUTTON = 2,
    BP_CHECKBOX = 3,
    BP_GROUPBOX = 4,
    BP_USERBUTTON = 5,
    BP_COMMANDLINK = 6,
    BP_COMMANDLINKGLYPH = 7,
    BP_RADIOBUTTON_HCDISABLED = 8,
    BP_CHECKBOX_HCDISABLED = 9,
    BP_GROUPBOX_HCDISABLED = 10,
    BP_PUSHBUTTONDROPDOWN = 11,
}
