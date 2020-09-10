// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_DESCRIPTOR_HEAP_DESC")]
    public unsafe partial struct DescriptorHeapDesc
    {
        public DescriptorHeapDesc
        (
            DescriptorHeapType type = default,
            uint numDescriptors = default,
            DescriptorHeapFlags flags = default,
            uint nodeMask = default
        )
        {
            Type = type;
            NumDescriptors = numDescriptors;
            Flags = flags;
            NodeMask = nodeMask;
        }


        [NativeName("Type", "D3D12_DESCRIPTOR_HEAP_TYPE")]
        [NativeName("Type.Name", "D3D12_DESCRIPTOR_HEAP_TYPE")]
        [NativeName("Name", "Type")]
        public DescriptorHeapType Type;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumDescriptors")]
        public uint NumDescriptors;

        [NativeName("Type", "D3D12_DESCRIPTOR_HEAP_FLAGS")]
        [NativeName("Type.Name", "D3D12_DESCRIPTOR_HEAP_FLAGS")]
        [NativeName("Name", "Flags")]
        public DescriptorHeapFlags Flags;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeMask")]
        public uint NodeMask;
    }
}
