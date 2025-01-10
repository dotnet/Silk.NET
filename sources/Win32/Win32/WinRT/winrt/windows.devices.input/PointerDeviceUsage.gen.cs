// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.devices.input.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public partial struct PointerDeviceUsage
{
    [NativeTypeName("UINT32")]
    public uint UsagePage;

    [NativeTypeName("UINT32")]
    public uint Usage;

    [NativeTypeName("INT32")]
    public int MinLogical;

    [NativeTypeName("INT32")]
    public int MaxLogical;

    [NativeTypeName("INT32")]
    public int MinPhysical;

    [NativeTypeName("INT32")]
    public int MaxPhysical;

    [NativeTypeName("UINT32")]
    public uint Unit;
    public float PhysicalMultiplier;
}
