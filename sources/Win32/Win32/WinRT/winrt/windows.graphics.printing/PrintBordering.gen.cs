// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum PrintBordering
{
    PrintBordering_Default = 0,
    PrintBordering_NotAvailable = 1,
    PrintBordering_PrinterCustom = 2,
    PrintBordering_Bordered = 3,
    PrintBordering_Borderless = 4,
}
