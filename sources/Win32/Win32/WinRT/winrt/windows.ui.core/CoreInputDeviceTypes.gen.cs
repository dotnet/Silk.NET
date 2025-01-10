// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[NativeTypeName("unsigned int")]
public enum CoreInputDeviceTypes : uint
{
    CoreInputDeviceTypes_None = 0,
    CoreInputDeviceTypes_Touch = 0x1,
    CoreInputDeviceTypes_Pen = 0x2,
    CoreInputDeviceTypes_Mouse = 0x4,
}
