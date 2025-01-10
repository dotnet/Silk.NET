// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.bluetooth.genericattributeprofile.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum GattOpenStatus
{
    GattOpenStatus_Unspecified = 0,
    GattOpenStatus_Success = 1,
    GattOpenStatus_AlreadyOpened = 2,
    GattOpenStatus_NotFound = 3,
    GattOpenStatus_SharingViolation = 4,
    GattOpenStatus_AccessDenied = 5,
}
