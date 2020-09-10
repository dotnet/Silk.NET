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
    [NativeName("Name", "D3D12_RESOURCE_ALIASING_BARRIER")]
    public unsafe partial struct ResourceAliasingBarrier
    {
        public ResourceAliasingBarrier
        (
            ID3D12Resource* pResourceBefore = default,
            ID3D12Resource* pResourceAfter = default
        )
        {
            PResourceBefore = pResourceBefore;
            PResourceAfter = pResourceAfter;
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pResourceBefore")]
        public ID3D12Resource* PResourceBefore;

        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pResourceAfter")]
        public ID3D12Resource* PResourceAfter;
    }
}
