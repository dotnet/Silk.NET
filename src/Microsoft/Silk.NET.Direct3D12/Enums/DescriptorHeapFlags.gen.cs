// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_FLAGS")]
    public enum DescriptorHeapFlags : int
    {
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_FLAG_NONE")]
        DescriptorHeapFlagNone = 0x0,
        [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_FLAG_SHADER_VISIBLE")]
        DescriptorHeapFlagShaderVisible = 0x1,
    }
}
