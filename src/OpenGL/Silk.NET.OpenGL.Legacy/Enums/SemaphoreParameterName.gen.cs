// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "SemaphoreParameterName")]
    public enum SemaphoreParameterName
    {
        [NativeName("Name", "GL_D3D12_FENCE_VALUE_EXT")]
        D3D12FenceValueExt = 0x9595,
    }
}
