// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum WwanDataClass : uint
{
    WwanDataClass_None = 0,
    WwanDataClass_Gprs = 0x1,
    WwanDataClass_Edge = 0x2,
    WwanDataClass_Umts = 0x4,
    WwanDataClass_Hsdpa = 0x8,
    WwanDataClass_Hsupa = 0x10,
    WwanDataClass_LteAdvanced = 0x20,
    WwanDataClass_NewRadioNonStandalone = 0x40,
    WwanDataClass_NewRadioStandalone = 0x80,
    WwanDataClass_Cdma1xRtt = 0x10000,
    WwanDataClass_Cdma1xEvdo = 0x20000,
    WwanDataClass_Cdma1xEvdoRevA = 0x40000,
    WwanDataClass_Cdma1xEvdv = 0x80000,
    WwanDataClass_Cdma3xRtt = 0x100000,
    WwanDataClass_Cdma1xEvdoRevB = 0x200000,
    WwanDataClass_CdmaUmb = 0x400000,
    WwanDataClass_Custom = 0x80000000,
}
