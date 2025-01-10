// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.media.streaming.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum DeviceTypes : uint
{
    DeviceTypes_Unknown = 0,
    DeviceTypes_DigitalMediaRenderer = 0x1,
    DeviceTypes_DigitalMediaServer = 0x2,
    DeviceTypes_DigitalMediaPlayer = 0x4,
}
