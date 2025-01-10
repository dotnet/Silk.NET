// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.graphics.printing.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum PrintQuality
{
    PrintQuality_Default = 0,
    PrintQuality_NotAvailable = 1,
    PrintQuality_PrinterCustom = 2,
    PrintQuality_Automatic = 3,
    PrintQuality_Draft = 4,
    PrintQuality_Fax = 5,
    PrintQuality_High = 6,
    PrintQuality_Normal = 7,
    PrintQuality_Photographic = 8,
    PrintQuality_Text = 9,
}
