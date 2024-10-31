// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_STATE_OBJECT_TYPE")]
    public enum StateObjectType : int
    {
        [Obsolete("Deprecated in favour of \"Collection\"")]
        [NativeName("Name", "D3D12_STATE_OBJECT_TYPE_COLLECTION")]
        StateObjectTypeCollection = 0x0,
        [Obsolete("Deprecated in favour of \"RaytracingPipeline\"")]
        [NativeName("Name", "D3D12_STATE_OBJECT_TYPE_RAYTRACING_PIPELINE")]
        StateObjectTypeRaytracingPipeline = 0x3,
        [Obsolete("Deprecated in favour of \"Executable\"")]
        [NativeName("Name", "D3D12_STATE_OBJECT_TYPE_EXECUTABLE")]
        StateObjectTypeExecutable = 0x4,
        [NativeName("Name", "D3D12_STATE_OBJECT_TYPE_COLLECTION")]
        Collection = 0x0,
        [NativeName("Name", "D3D12_STATE_OBJECT_TYPE_RAYTRACING_PIPELINE")]
        RaytracingPipeline = 0x3,
        [NativeName("Name", "D3D12_STATE_OBJECT_TYPE_EXECUTABLE")]
        Executable = 0x4,
    }
}
