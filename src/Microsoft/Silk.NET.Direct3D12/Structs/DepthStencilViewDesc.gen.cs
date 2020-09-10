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
    [NativeName("Name", "D3D12_DEPTH_STENCIL_VIEW_DESC")]
    public unsafe partial struct DepthStencilViewDesc
    {
        public DepthStencilViewDesc
        (
            Silk.NET.DXGI.Format format = default,
            DsvDimension viewDimension = default,
            DsvFlags flags = default
        )
        {
            Format = format;
            ViewDimension = viewDimension;
            Flags = flags;
        }


        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "D3D12_DSV_DIMENSION")]
        [NativeName("Type.Name", "D3D12_DSV_DIMENSION")]
        [NativeName("Name", "ViewDimension")]
        public DsvDimension ViewDimension;

        [NativeName("Type", "D3D12_DSV_FLAGS")]
        [NativeName("Type.Name", "D3D12_DSV_FLAGS")]
        [NativeName("Name", "Flags")]
        public DsvFlags Flags;
    }
}
