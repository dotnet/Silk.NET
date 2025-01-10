// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum PrintOrientation
{
    PrintOrientation_Default = 0,
    PrintOrientation_NotAvailable = 1,
    PrintOrientation_PrinterCustom = 2,
    PrintOrientation_Portrait = 3,
    PrintOrientation_PortraitFlipped = 4,
    PrintOrientation_Landscape = 5,
    PrintOrientation_LandscapeFlipped = 6,
}
