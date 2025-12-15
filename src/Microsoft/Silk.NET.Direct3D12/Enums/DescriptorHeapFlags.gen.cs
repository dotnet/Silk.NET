// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_FLAGS")]
    public enum DescriptorHeapFlags : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_FLAG_NONE")]
        DescriptorHeapFlagNone = 0x0,
        [Obsolete("Deprecated in favour of \"ShaderVisible\"")]
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_FLAG_SHADER_VISIBLE")]
        DescriptorHeapFlagShaderVisible = 0x1,
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_FLAG_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_FLAG_SHADER_VISIBLE")]
        ShaderVisible = 0x1,
    }
}
