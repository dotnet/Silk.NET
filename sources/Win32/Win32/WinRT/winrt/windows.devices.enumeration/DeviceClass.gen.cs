// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.enumeration.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum DeviceClass
{
    DeviceClass_All = 0,
    DeviceClass_AudioCapture = 1,
    DeviceClass_AudioRender = 2,
    DeviceClass_PortableStorageDevice = 3,
    DeviceClass_VideoCapture = 4,
    DeviceClass_ImageScanner = 5,
    DeviceClass_Location = 6,
}
