// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_PROGRAM_TYPE")]
    public enum ProgramType : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"GenericPipeline\"")]
        [NativeName("Name", "D3D12_PROGRAM_TYPE_GENERIC_PIPELINE")]
        ProgramTypeGenericPipeline = 0x1,
        [Obsolete("Deprecated in favour of \"RaytracingPipeline\"")]
        [NativeName("Name", "D3D12_PROGRAM_TYPE_RAYTRACING_PIPELINE")]
        ProgramTypeRaytracingPipeline = 0x4,
        [Obsolete("Deprecated in favour of \"WorkGraph\"")]
        [NativeName("Name", "D3D12_PROGRAM_TYPE_WORK_GRAPH")]
        ProgramTypeWorkGraph = 0x5,
        [NativeName("Name", "D3D12_PROGRAM_TYPE_GENERIC_PIPELINE")]
        GenericPipeline = 0x1,
        [NativeName("Name", "D3D12_PROGRAM_TYPE_RAYTRACING_PIPELINE")]
        RaytracingPipeline = 0x4,
        [NativeName("Name", "D3D12_PROGRAM_TYPE_WORK_GRAPH")]
        WorkGraph = 0x5,
    }
}
