// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.SPIRV.Cross
{
    [NativeName("Name", "spvc_msl_shader_variable_rate")]
    public enum MslShaderVariableRate : int
    {
        [NativeName("Name", "SPVC_MSL_SHADER_VARIABLE_RATE_PER_VERTEX")]
        PerVertex = 0x0,
        [NativeName("Name", "SPVC_MSL_SHADER_VARIABLE_RATE_PER_PRIMITIVE")]
        PerPrimitive = 0x1,
        [NativeName("Name", "SPVC_MSL_SHADER_VARIABLE_RATE_PER_PATCH")]
        PerPatch = 0x2,
        [NativeName("Name", "SPVC_MSL_SHADER_VARIABLE_RATE_INT_MAX")]
        IntMax = 0x7FFFFFFF,
    }
}
