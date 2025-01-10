// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum Panel
{
    Panel_Unknown = 0,
    Panel_Front = 1,
    Panel_Back = 2,
    Panel_Top = 3,
    Panel_Bottom = 4,
    Panel_Left = 5,
    Panel_Right = 6,
}
