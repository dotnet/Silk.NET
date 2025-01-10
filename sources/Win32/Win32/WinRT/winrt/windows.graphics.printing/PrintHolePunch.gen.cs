// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum PrintHolePunch
{
    PrintHolePunch_Default = 0,
    PrintHolePunch_NotAvailable = 1,
    PrintHolePunch_PrinterCustom = 2,
    PrintHolePunch_None = 3,
    PrintHolePunch_LeftEdge = 4,
    PrintHolePunch_RightEdge = 5,
    PrintHolePunch_TopEdge = 6,
    PrintHolePunch_BottomEdge = 7,
}
