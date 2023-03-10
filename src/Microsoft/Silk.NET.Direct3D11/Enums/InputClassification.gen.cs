// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_INPUT_CLASSIFICATION")]
    public enum InputClassification : int
    {
        [Obsolete("Deprecated in favour of \"PerVertexData\"")]
        [NativeName("Name", "D3D11_INPUT_PER_VERTEX_DATA")]
        InputPerVertexData = 0x0,
        [Obsolete("Deprecated in favour of \"PerInstanceData\"")]
        [NativeName("Name", "D3D11_INPUT_PER_INSTANCE_DATA")]
        InputPerInstanceData = 0x1,
        [NativeName("Name", "D3D11_INPUT_PER_VERTEX_DATA")]
        PerVertexData = 0x0,
        [NativeName("Name", "D3D11_INPUT_PER_INSTANCE_DATA")]
        PerInstanceData = 0x1,
    }
}
