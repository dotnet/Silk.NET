// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenCL
{
    [NativeName("Name", "cl_sampler_properties")]
    public enum SamplerProperties : ulong
    {
        [NativeName("Name", "CL_SAMPLER_MIP_FILTER_MODE_KHR")]
        MipFilterModeKhr = 0x1155,
        [NativeName("Name", "CL_SAMPLER_LOD_MIN_KHR")]
        LodMinKhr = 0x1156,
        [NativeName("Name", "CL_SAMPLER_LOD_MAX_KHR")]
        LodMaxKhr = 0x1157,
    }
}
