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
        SamplerReferenceCount = 0x1150,
        [NativeName("Name", "CL_SAMPLER_CONTEXT")]
        SamplerContext = 0x1151,
        [NativeName("Name", "CL_SAMPLER_NORMALIZED_COORDS")]
        SamplerNormalizedCoords = 0x1152,
        [NativeName("Name", "CL_SAMPLER_ADDRESSING_MODE")]
        SamplerAddressingMode = 0x1153,
        [NativeName("Name", "CL_SAMPLER_FILTER_MODE")]
        SamplerFilterMode = 0x1154,
        [NativeName("Name", "CL_SAMPLER_MIP_FILTER_MODE")]
        SamplerMipFilterMode = 0x1155,
        [NativeName("Name", "CL_SAMPLER_LOD_MIN")]
        SamplerLodMin = 0x1156,
        [NativeName("Name", "CL_SAMPLER_LOD_MAX")]
        SamplerLodMax = 0x1157,
        [NativeName("Name", "CL_SAMPLER_PROPERTIES")]
        SamplerProperties = 0x1158,
    }
}
