// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "FenceParameterNameNV")]
    public enum FenceParameterNameNV : int
    {
        [Obsolete("Deprecated in favour of \"StatusNV\"")]
        [NativeName("Name", "GL_FENCE_STATUS_NV")]
        FenceStatusNV = 0x84F3,
        [Obsolete("Deprecated in favour of \"ConditionNV\"")]
        [NativeName("Name", "GL_FENCE_CONDITION_NV")]
        FenceConditionNV = 0x84F4,
        [NativeName("Name", "GL_FENCE_STATUS_NV")]
        StatusNV = 0x84F3,
        [NativeName("Name", "GL_FENCE_CONDITION_NV")]
        ConditionNV = 0x84F4,
    }
}
