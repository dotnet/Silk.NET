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
    [NativeName("Name", "D3D12_SUBRESOURCE_DATA")]
    public unsafe partial struct SubresourceData
    {
        public SubresourceData
        (
            void* pData = default,
            int rowPitch = default,
            int slicePitch = default
        )
        {
            PData = pData;
            RowPitch = rowPitch;
            SlicePitch = slicePitch;
        }


        [NativeName("Type", "const void *")]
        [NativeName("Type.Name", "const void *")]
        [NativeName("Name", "pData")]
        public void* PData;

        [NativeName("Type", "LONG_PTR")]
        [NativeName("Type.Name", "LONG_PTR")]
        [NativeName("Name", "RowPitch")]
        public int RowPitch;

        [NativeName("Type", "LONG_PTR")]
        [NativeName("Type.Name", "LONG_PTR")]
        [NativeName("Name", "SlicePitch")]
        public int SlicePitch;
    }
}
