// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES
{
    [NativeName("Name", "FenceParameterNameNV")]
    public enum FenceParameterNameNV : int
    {
        [NativeName("Name", "GL_FENCE_STATUS_NV")]
        FenceStatusNV = 0x84F3,
        [NativeName("Name", "GL_FENCE_CONDITION_NV")]
        FenceConditionNV = 0x84F4,
    }
}
