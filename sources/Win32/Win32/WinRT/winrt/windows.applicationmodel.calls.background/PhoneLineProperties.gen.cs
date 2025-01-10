// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.calls.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum PhoneLineProperties : uint
{
    PhoneLineProperties_None = 0,
    PhoneLineProperties_BrandingOptions = 0x1,
    PhoneLineProperties_CanDial = 0x2,
    PhoneLineProperties_CellularDetails = 0x4,
    PhoneLineProperties_DisplayColor = 0x8,
    PhoneLineProperties_DisplayName = 0x10,
    PhoneLineProperties_NetworkName = 0x20,
    PhoneLineProperties_NetworkState = 0x40,
    PhoneLineProperties_Transport = 0x80,
    PhoneLineProperties_Voicemail = 0x100,
}
