// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
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
            ID3D12Resource* pSrcResource = null,
            ID3D12Resource* pDstResource = null,
            uint? subresourceCount = null,
            RenderPassEndingAccessResolveSubresourceParameters* pSubresourceParameters = null,
            Silk.NET.DXGI.Format? format = null,
            ResolveMode? resolveMode = null,
            Silk.NET.Core.Bool32? preserveResolveSource = null
        ) : this()
        {
            if (pSrcResource is not null)
            {
                PSrcResource = pSrcResource;
            }

            if (pDstResource is not null)
            {
                PDstResource = pDstResource;
            }

            if (subresourceCount is not null)
            {
                SubresourceCount = subresourceCount.Value;
            }

            if (pSubresourceParameters is not null)
            {
                PSubresourceParameters = pSubresourceParameters;
            }

            if (format is not null)
            {
                Format = format.Value;
            }

            if (resolveMode is not null)
            {
                ResolveMode = resolveMode.Value;
            }

            if (preserveResolveSource is not null)
            {
                PreserveResolveSource = preserveResolveSource.Value;
            }
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
        public Silk.NET.Core.Bool32 PreserveResolveSource;
    }
}
