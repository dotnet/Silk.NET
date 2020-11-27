// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [NativeName("Name", "D3D11_MAPPED_SUBRESOURCE")]
    public unsafe partial struct MappedSubresource
    {
        public MappedSubresource
        (
            void* pData = null,
            uint? rowPitch = null,
            uint? depthPitch = null
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

            if (depthPitch is not null)
            {
                DepthPitch = depthPitch.Value;
            }
        }


        [NativeName("Type", "void *")]
        [NativeName("Type.Name", "void *")]
        [NativeName("Name", "pData")]
        public void* PData;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "RowPitch")]
        public uint RowPitch;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DepthPitch")]
        public uint DepthPitch;
    }
}
