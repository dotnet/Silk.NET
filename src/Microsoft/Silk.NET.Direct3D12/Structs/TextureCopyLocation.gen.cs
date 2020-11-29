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

namespace Silk.NET.Direct3D12
{
    [NativeName("Name", "D3D12_TEXTURE_COPY_LOCATION")]
    public unsafe partial struct TextureCopyLocation
    {
        public TextureCopyLocation
        (
            ID3D12Resource* pResource = null,
            TextureCopyType? type = null
        ) : this()
        {
            if (pResource is not null)
            {
                PResource = pResource;
            }

            if (type is not null)
            {
                Type = type.Value;
            }
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pResource")]
        public ID3D12Resource* PResource;

        [NativeName("Type", "D3D12_TEXTURE_COPY_TYPE")]
        [NativeName("Type.Name", "D3D12_TEXTURE_COPY_TYPE")]
        [NativeName("Name", "Type")]
        public TextureCopyType Type;
    }
}
