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
    [NativeName("Name", "D3D12_HEAP_DESC")]
    public unsafe partial struct HeapDesc
    {
        public HeapDesc
        (
            ulong sizeInBytes = default,
            HeapProperties properties = default,
            ulong alignment = default,
            HeapFlags flags = default
        )
        {
            SizeInBytes = sizeInBytes;
            Properties = properties;
            Alignment = alignment;
            Flags = flags;
        }


        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "SizeInBytes")]
        public ulong SizeInBytes;

        [NativeName("Type", "D3D12_HEAP_PROPERTIES")]
        [NativeName("Type.Name", "D3D12_HEAP_PROPERTIES")]
        [NativeName("Name", "Properties")]
        public HeapProperties Properties;

        [NativeName("Type", "UINT64")]
        [NativeName("Type.Name", "UINT64")]
        [NativeName("Name", "Alignment")]
        public ulong Alignment;

        [NativeName("Type", "D3D12_HEAP_FLAGS")]
        [NativeName("Type.Name", "D3D12_HEAP_FLAGS")]
        [NativeName("Name", "Flags")]
        public HeapFlags Flags;
    }
}
