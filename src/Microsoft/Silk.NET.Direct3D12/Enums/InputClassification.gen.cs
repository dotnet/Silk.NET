// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_INPUT_CLASSIFICATION")]
    public enum InputClassification : int
    {
        [NativeName("Name", "D3D12_INPUT_CLASSIFICATION_PER_VERTEX_DATA")]
        InputClassificationPerVertexData = 0x0,
        [NativeName("Name", "D3D12_INPUT_CLASSIFICATION_PER_INSTANCE_DATA")]
        InputClassificationPerInstanceData = 0x1,
    }
}
