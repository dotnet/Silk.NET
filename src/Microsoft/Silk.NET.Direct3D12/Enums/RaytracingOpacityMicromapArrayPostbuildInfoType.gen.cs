// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_TYPE")]
    public enum RaytracingOpacityMicromapArrayPostbuildInfoType : int
    {
        [Obsolete("Deprecated in favour of \"CurrentSize\"")]
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_CURRENT_SIZE")]
        RaytracingOpacityMicromapArrayPostbuildInfoCurrentSize = 0x0,
        [Obsolete("Deprecated in favour of \"ToolsVisualization\"")]
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_TOOLS_VISUALIZATION")]
        RaytracingOpacityMicromapArrayPostbuildInfoToolsVisualization = 0x1,
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_CURRENT_SIZE")]
        CurrentSize = 0x0,
        [NativeName("Name", "D3D12_RAYTRACING_OPACITY_MICROMAP_ARRAY_POSTBUILD_INFO_TOOLS_VISUALIZATION")]
        ToolsVisualization = 0x1,
    }
}
