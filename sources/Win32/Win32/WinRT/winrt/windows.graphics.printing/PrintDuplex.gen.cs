// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum PrintDuplex
{
    PrintDuplex_Default = 0,
    PrintDuplex_NotAvailable = 1,
    PrintDuplex_PrinterCustom = 2,
    PrintDuplex_OneSided = 3,
    PrintDuplex_TwoSidedShortEdge = 4,
    PrintDuplex_TwoSidedLongEdge = 5,
}
