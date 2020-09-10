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
    [StructLayout(LayoutKind.Explicit)]
    [NativeName("Name", "__AnonymousRecord_d3d12_L3559_C5")]
    public unsafe partial struct AnonymousRecordD3d12L3559C5
    {
        public AnonymousRecordD3d12L3559C5
        (
            RootDescriptorTable1 descriptorTable = default,
            RootConstants constants = default,
            RootDescriptor1 descriptor = default
        )
        {
            DescriptorTable = descriptorTable;
            Constants = constants;
            Descriptor = descriptor;
        }


        [FieldOffset(0)]
        [NativeName("Type", "D3D12_ROOT_DESCRIPTOR_TABLE1")]
        [NativeName("Type.Name", "D3D12_ROOT_DESCRIPTOR_TABLE1")]
        [NativeName("Name", "DescriptorTable")]
        public RootDescriptorTable1 DescriptorTable;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_ROOT_CONSTANTS")]
        [NativeName("Type.Name", "D3D12_ROOT_CONSTANTS")]
        [NativeName("Name", "Constants")]
        public RootConstants Constants;

        [FieldOffset(0)]
        [NativeName("Type", "D3D12_ROOT_DESCRIPTOR1")]
        [NativeName("Type.Name", "D3D12_ROOT_DESCRIPTOR1")]
        [NativeName("Name", "Descriptor")]
        public RootDescriptor1 Descriptor;
    }
}
