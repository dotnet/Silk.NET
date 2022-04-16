// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_sampler_info")]
    public enum SamplerInfo : int
    {
        [NativeName("Name", "CL_SAMPLER_REFERENCE_COUNT")]
        ReferenceCount = 0x1150,
        [NativeName("Name", "CL_SAMPLER_CONTEXT")]
        Context = 0x1151,
        [NativeName("Name", "CL_SAMPLER_NORMALIZED_COORDS")]
        NormalizedCoords = 0x1152,
        [NativeName("Name", "CL_SAMPLER_ADDRESSING_MODE")]
        AddressingMode = 0x1153,
        [NativeName("Name", "CL_SAMPLER_FILTER_MODE")]
        FilterMode = 0x1154,
        [NativeName("Name", "CL_SAMPLER_MIP_FILTER_MODE")]
        MipFilterMode = 0x1155,
        [NativeName("Name", "CL_SAMPLER_LOD_MIN")]
        LodMin = 0x1156,
        [NativeName("Name", "CL_SAMPLER_LOD_MAX")]
        LodMax = 0x1157,
        [NativeName("Name", "CL_SAMPLER_PROPERTIES")]
        Properties = 0x1158,
    }
}
