// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "CombinerBiasNV")]
    public enum CombinerBiasNV : int
    {
        [NativeName("Name", "GL_NONE")]
        None = 0x0,
        [NativeName("Name", "GL_BIAS_BY_NEGATIVE_ONE_HALF_NV")]
        BiasByNegativeOneHalfNV = 0x8541,
    }
}
