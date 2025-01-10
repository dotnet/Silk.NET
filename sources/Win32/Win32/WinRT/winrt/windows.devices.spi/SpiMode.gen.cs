// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.spi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SpiMode
{
    SpiMode_Mode0 = 0,
    SpiMode_Mode1 = 1,
    SpiMode_Mode2 = 2,
    SpiMode_Mode3 = 3,
}
