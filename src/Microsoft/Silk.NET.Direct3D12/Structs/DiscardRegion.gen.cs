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
    [NativeName("Name", "D3D12_DISCARD_REGION")]
    public unsafe partial struct DiscardRegion
    {
        public DiscardRegion
        (
            uint numRects = default,
            Silk.NET.Core.Runtime.Windows.TagRect* pRects = default,
            uint firstSubresource = default,
            uint numSubresources = default
        )
        {
            NumRects = numRects;
            PRects = pRects;
            FirstSubresource = firstSubresource;
            NumSubresources = numSubresources;
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumRects")]
        public uint NumRects;

        [NativeName("Type", "const D3D12_RECT *")]
        [NativeName("Type.Name", "const D3D12_RECT *")]
        [NativeName("Name", "pRects")]
        public Silk.NET.Core.Runtime.Windows.TagRect* PRects;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "FirstSubresource")]
        public uint FirstSubresource;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NumSubresources")]
        public uint NumSubresources;
    }
}
