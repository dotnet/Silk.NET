// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkAccelerationStructureMatrixMotionInstanceNV")]
public partial struct AccelerationStructureMatrixMotionInstanceNV
{
    [NativeName("transformT0")]
    public TransformMatrixKHR TransformT0;

    [NativeName("transformT1")]
    public TransformMatrixKHR TransformT1;

    [NativeName("_bitfield1")]
    public uint Bitfield1;

    [NativeName("instanceCustomIndex")]
    public uint InstanceCustomIndex
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Bitfield1 & 0xFFFFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield1 = (Bitfield1 & ~0xFFFFFFu) | (value & 0xFFFFFFu); }
    }

    [NativeName("mask")]
    public uint Mask
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (Bitfield1 >> 24) & 0xFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield1 = (Bitfield1 & ~(0xFFu << 24)) | ((value & 0xFFu) << 24); }
    }

    [NativeName("_bitfield2")]
    public uint Bitfield2;

    [NativeName("instanceShaderBindingTableRecordOffset")]
    public uint InstanceShaderBindingTableRecordOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return Bitfield2 & 0xFFFFFFu; }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield2 = (Bitfield2 & ~0xFFFFFFu) | (value & 0xFFFFFFu); }
    }

    [NativeName("flags")]
    public GeometryInstanceFlagsKHR Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        readonly get { return (GeometryInstanceFlagsKHR)((Bitfield2 >> 24) & 0xFFu); }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set { Bitfield2 = (Bitfield2 & ~(0xFFu << 24)) | (((uint)(value) & 0xFFu) << 24); }
    }

    [NativeName("accelerationStructureReference")]
    public ulong AccelerationStructureReference;
}
