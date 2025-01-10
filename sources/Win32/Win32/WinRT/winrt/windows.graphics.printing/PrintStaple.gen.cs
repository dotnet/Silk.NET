// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum PrintStaple
{
    PrintStaple_Default = 0,
    PrintStaple_NotAvailable = 1,
    PrintStaple_PrinterCustom = 2,
    PrintStaple_None = 3,
    PrintStaple_StapleTopLeft = 4,
    PrintStaple_StapleTopRight = 5,
    PrintStaple_StapleBottomLeft = 6,
    PrintStaple_StapleBottomRight = 7,
    PrintStaple_StapleDualLeft = 8,
    PrintStaple_StapleDualRight = 9,
    PrintStaple_StapleDualTop = 10,
    PrintStaple_StapleDualBottom = 11,
    PrintStaple_SaddleStitch = 12,
}
