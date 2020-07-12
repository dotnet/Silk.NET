// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "FenceParameterNameNV")]
    public enum FenceParameterNameNV
    {
        [NativeName("Name", "GL_FENCE_STATUS_NV")]
        FenceStatusNV = 0x84F3,
        [NativeName("Name", "GL_FENCE_CONDITION_NV")]
        FenceConditionNV = 0x84F4,
    }
}
