// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_MEMCPY_DEST")]
    public unsafe partial struct MemcpyDest
    {
        public MemcpyDest
        (
            void* pData = null,
            uint? rowPitch = null,
            uint? slicePitch = null
        ) : this()
        {
            if (pData is not null)
            {
                PData = pData;
            }

            if (rowPitch is not null)
            {
                RowPitch = rowPitch.Value;
            }

            if (slicePitch is not null)
            {
                SlicePitch = slicePitch.Value;
            }
        }


        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pData")]
        public void* PData;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "RowPitch")]
        public uint RowPitch;

        [NativeName("Type", "SIZE_T")]
        [NativeName("Type.Name", "SIZE_T")]
        [NativeName("Name", "SlicePitch")]
        public uint SlicePitch;
    }
}
