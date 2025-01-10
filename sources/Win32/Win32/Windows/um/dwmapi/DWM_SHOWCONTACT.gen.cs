// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Flags]
public enum DWM_SHOWCONTACT
{
    DWMSC_DOWN = 0x00000001,
    DWMSC_UP = 0x00000002,
    DWMSC_DRAG = 0x00000004,
    DWMSC_HOLD = 0x00000008,
    DWMSC_PENBARREL = 0x00000010,
    DWMSC_NONE = 0x00000000,
    DWMSC_ALL = unchecked((int)(0xFFFFFFFF)),
}
