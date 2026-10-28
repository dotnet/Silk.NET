// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("_physicalDevices_e__FixedBuffer")]
public unsafe partial struct PhysicalDeviceGroupPropertiesPhysicalDevices
{
    [NativeName("e0")]
    public PhysicalDeviceHandle E0;

    [NativeName("e1")]
    public PhysicalDeviceHandle E1;

    [NativeName("e2")]
    public PhysicalDeviceHandle E2;

    [NativeName("e3")]
    public PhysicalDeviceHandle E3;

    [NativeName("e4")]
    public PhysicalDeviceHandle E4;

    [NativeName("e5")]
    public PhysicalDeviceHandle E5;

    [NativeName("e6")]
    public PhysicalDeviceHandle E6;

    [NativeName("e7")]
    public PhysicalDeviceHandle E7;

    [NativeName("e8")]
    public PhysicalDeviceHandle E8;

    [NativeName("e9")]
    public PhysicalDeviceHandle E9;

    [NativeName("e10")]
    public PhysicalDeviceHandle E10;

    [NativeName("e11")]
    public PhysicalDeviceHandle E11;

    [NativeName("e12")]
    public PhysicalDeviceHandle E12;

    [NativeName("e13")]
    public PhysicalDeviceHandle E13;

    [NativeName("e14")]
    public PhysicalDeviceHandle E14;

    [NativeName("e15")]
    public PhysicalDeviceHandle E15;

    [NativeName("e16")]
    public PhysicalDeviceHandle E16;

    [NativeName("e17")]
    public PhysicalDeviceHandle E17;

    [NativeName("e18")]
    public PhysicalDeviceHandle E18;

    [NativeName("e19")]
    public PhysicalDeviceHandle E19;

    [NativeName("e20")]
    public PhysicalDeviceHandle E20;

    [NativeName("e21")]
    public PhysicalDeviceHandle E21;

    [NativeName("e22")]
    public PhysicalDeviceHandle E22;

    [NativeName("e23")]
    public PhysicalDeviceHandle E23;

    [NativeName("e24")]
    public PhysicalDeviceHandle E24;

    [NativeName("e25")]
    public PhysicalDeviceHandle E25;

    [NativeName("e26")]
    public PhysicalDeviceHandle E26;

    [NativeName("e27")]
    public PhysicalDeviceHandle E27;

    [NativeName("e28")]
    public PhysicalDeviceHandle E28;

    [NativeName("e29")]
    public PhysicalDeviceHandle E29;

    [NativeName("e30")]
    public PhysicalDeviceHandle E30;

    [NativeName("e31")]
    public PhysicalDeviceHandle E31;
    public ref PhysicalDeviceHandle this[int index]
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            fixed (PhysicalDeviceHandle* pThis = &E0)
            {
                return ref pThis[index];
            }
        }
    }
}
