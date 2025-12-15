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
    [NativeName("Name", "D3D12_RENDER_PASS_ENDING_ACCESS_RESOLVE_SUBRESOURCE_PARAMETERS")]
    public unsafe partial struct RenderPassEndingAccessResolveSubresourceParameters
    {
        public RenderPassEndingAccessResolveSubresourceParameters
        (
            uint? srcSubresource = null,
            uint? dstSubresource = null,
            uint? dstX = null,
            uint? dstY = null,
            Silk.NET.Maths.Box2D<int>? srcRect = null
        ) : this()
        {
            if (srcSubresource is not null)
            {
                SrcSubresource = srcSubresource.Value;
            }

            if (dstSubresource is not null)
            {
                DstSubresource = dstSubresource.Value;
            }

            if (dstX is not null)
            {
                DstX = dstX.Value;
            }

            if (dstY is not null)
            {
                DstY = dstY.Value;
            }

            if (srcRect is not null)
            {
                SrcRect = srcRect.Value;
            }
        }


        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "SrcSubresource")]
        public uint SrcSubresource;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DstSubresource")]
        public uint DstSubresource;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DstX")]
        public uint DstX;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "DstY")]
        public uint DstY;

        [NativeName("Type", "D3D12_RECT")]
        [NativeName("Type.Name", "D3D12_RECT")]
        [NativeName("Name", "SrcRect")]
        public Silk.NET.Maths.Box2D<int> SrcRect;
    }
}
