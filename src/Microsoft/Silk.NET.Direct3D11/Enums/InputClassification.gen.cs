// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_INPUT_CLASSIFICATION")]
    public enum InputClassification
    {
        [NativeName("Name", "D3D11_INPUT_PER_VERTEX_DATA")]
        InputPerVertexData = 0x0,
        [NativeName("Name", "D3D11_INPUT_PER_INSTANCE_DATA")]
        InputPerInstanceData = 0x1,
    }
}
