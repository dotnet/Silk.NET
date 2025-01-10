// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum PrintBinding
{
    PrintBinding_Default = 0,
    PrintBinding_NotAvailable = 1,
    PrintBinding_PrinterCustom = 2,
    PrintBinding_None = 3,
    PrintBinding_Bale = 4,
    PrintBinding_BindBottom = 5,
    PrintBinding_BindLeft = 6,
    PrintBinding_BindRight = 7,
    PrintBinding_BindTop = 8,
    PrintBinding_Booklet = 9,
    PrintBinding_EdgeStitchBottom = 10,
    PrintBinding_EdgeStitchLeft = 11,
    PrintBinding_EdgeStitchRight = 12,
    PrintBinding_EdgeStitchTop = 13,
    PrintBinding_Fold = 14,
    PrintBinding_JogOffset = 15,
    PrintBinding_Trim = 16,
}
