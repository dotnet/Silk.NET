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
    [NativeName("Name", "D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_PARAMETERS")]
    public unsafe partial struct RenderPassEndingAccessResolveParameters
    {
        public RenderPassEndingAccessResolveParameters
        (
            ID3D12Resource* pSrcResource = default,
            ID3D12Resource* pDstResource = default,
            uint subresourceCount = default,
            RenderPassEndingAccessResolveSubresourceParameters* pSubresourceParameters = default,
            Silk.NET.DXGI.Format format = default,
            ResolveMode resolveMode = default,
            int preserveResolveSource = default
        )
        {
            PSrcResource = pSrcResource;
            PDstResource = pDstResource;
            SubresourceCount = subresourceCount;
            PSubresourceParameters = pSubresourceParameters;
            Format = format;
            ResolveMode = resolveMode;
            PreserveResolveSource = preserveResolveSource;
        }


        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pSrcResource")]
        public ID3D12Resource* PSrcResource;

        [NativeName("Type", "ID3D12Resource *")]
        [NativeName("Type.Name", "ID3D12Resource *")]
        [NativeName("Name", "pDstResource")]
        public ID3D12Resource* PDstResource;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SubresourceCount")]
        public uint SubresourceCount;

        [NativeName("Type", "const D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_SUBRESOURCE_PARAMETERS *")]
        [NativeName("Type.Name", "const D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_SUBRESOURCE_PARAMETERS *")]
        [NativeName("Name", "pSubresourceParameters")]
        public RenderPassEndingAccessResolveSubresourceParameters* PSubresourceParameters;

        [NativeName("Type", "DXGI_FORMAT")]
        [NativeName("Type.Name", "DXGI_FORMAT")]
        [NativeName("Name", "Format")]
        public Silk.NET.DXGI.Format Format;

        [NativeName("Type", "D3D12_RESOLVE_MODE")]
        [NativeName("Type.Name", "D3D12_RESOLVE_MODE")]
        [NativeName("Name", "ResolveMode")]
        public ResolveMode ResolveMode;

        [NativeName("Type", "BOOL")]
        [NativeName("Type.Name", "BOOL")]
        [NativeName("Name", "PreserveResolveSource")]
        public int PreserveResolveSource;
    }
}
