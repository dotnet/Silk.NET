// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "FenceConditionNV")]
    public enum FenceConditionNV
    {
        [NativeName("Name", "GL_ALL_COMPLETED_NV")]
        AllCompletedNV = 0x84F2,
    }
}
