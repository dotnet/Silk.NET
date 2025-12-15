// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_NODE_TYPE")]
    public enum NodeType : int
    {
        [Obsolete("Deprecated in favour of \"Shader\"")]
        [NativeName("Name", "D3D12_NODE_TYPE_SHADER")]
        NodeTypeShader = 0x0,
        [NativeName("Name", "D3D12_NODE_TYPE_SHADER")]
        Shader = 0x0,
    }
}
