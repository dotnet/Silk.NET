// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.sensors.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum SimpleOrientation
{
    SimpleOrientation_NotRotated = 0,
    SimpleOrientation_Rotated90DegreesCounterclockwise = 1,
    SimpleOrientation_Rotated180DegreesCounterclockwise = 2,
    SimpleOrientation_Rotated270DegreesCounterclockwise = 3,
    SimpleOrientation_Faceup = 4,
    SimpleOrientation_Facedown = 5,
}
