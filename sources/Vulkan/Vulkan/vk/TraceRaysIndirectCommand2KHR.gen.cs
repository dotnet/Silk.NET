// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// Ported from the Vulkan headers and corresponding dependencies.
// Original source is Copyright 2015-2025 The Khronos Group Inc. Licensed under the MIT license.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Vulkan;

[NativeName("VkTraceRaysIndirectCommand2KHR")]
public partial struct TraceRaysIndirectCommand2KHR
{
    [NativeName("raygenShaderRecordAddress")]
    public ulong RaygenShaderRecordAddress;

    [NativeName("raygenShaderRecordSize")]
    public ulong RaygenShaderRecordSize;

    [NativeName("missShaderBindingTableAddress")]
    public ulong MissShaderBindingTableAddress;

    [NativeName("missShaderBindingTableSize")]
    public ulong MissShaderBindingTableSize;

    [NativeName("missShaderBindingTableStride")]
    public ulong MissShaderBindingTableStride;

    [NativeName("hitShaderBindingTableAddress")]
    public ulong HitShaderBindingTableAddress;

    [NativeName("hitShaderBindingTableSize")]
    public ulong HitShaderBindingTableSize;

    [NativeName("hitShaderBindingTableStride")]
    public ulong HitShaderBindingTableStride;

    [NativeName("callableShaderBindingTableAddress")]
    public ulong CallableShaderBindingTableAddress;

    [NativeName("callableShaderBindingTableSize")]
    public ulong CallableShaderBindingTableSize;

    [NativeName("callableShaderBindingTableStride")]
    public ulong CallableShaderBindingTableStride;

    [NativeName("width")]
    public uint Width;

    [NativeName("height")]
    public uint Height;

    [NativeName("depth")]
    public uint Depth;
}
