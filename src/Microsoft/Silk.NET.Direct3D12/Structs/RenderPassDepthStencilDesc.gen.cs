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
    [NativeName("Name", "D3D12_RENDER_PASS_DEPTH_STENCIL_DESC")]
    public unsafe partial struct RenderPassDepthStencilDesc
    {
        public RenderPassDepthStencilDesc
        (
            CpuDescriptorHandle? cpuDescriptor = null,
            RenderPassBeginningAccess? depthBeginningAccess = null,
            RenderPassBeginningAccess? stencilBeginningAccess = null,
            RenderPassEndingAccess? depthEndingAccess = null,
            RenderPassEndingAccess? stencilEndingAccess = null
        ) : this()
        {
            if (cpuDescriptor is not null)
            {
                CpuDescriptor = cpuDescriptor.Value;
            }

            if (depthBeginningAccess is not null)
            {
                DepthBeginningAccess = depthBeginningAccess.Value;
            }

            if (stencilBeginningAccess is not null)
            {
                StencilBeginningAccess = stencilBeginningAccess.Value;
            }

            if (depthEndingAccess is not null)
            {
                DepthEndingAccess = depthEndingAccess.Value;
            }

            if (stencilEndingAccess is not null)
            {
                StencilEndingAccess = stencilEndingAccess.Value;
            }
        }


        [NativeName("Type", "D3D12_CPU_DESCRIPTOR_HANDLE")]
        [NativeName("Type.Name", "D3D12_CPU_DESCRIPTOR_HANDLE")]
        [NativeName("Name", "cpuDescriptor")]
        public CpuDescriptorHandle CpuDescriptor;

        [NativeName("Type", "D3D12_RENDER_PASS_BEGINNING_ACCESS")]
        [NativeName("Type.Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS")]
        [NativeName("Name", "DepthBeginningAccess")]
        public RenderPassBeginningAccess DepthBeginningAccess;

        [NativeName("Type", "D3D12_RENDER_PASS_BEGINNING_ACCESS")]
        [NativeName("Type.Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS")]
        [NativeName("Name", "StencilBeginningAccess")]
        public RenderPassBeginningAccess StencilBeginningAccess;

        [NativeName("Type", "D3D12_RENDER_PASS_ENDING_ACCESS")]
        [NativeName("Type.Name", "D3D12_RENDER_PASS_ENDING_ACCESS")]
        [NativeName("Name", "DepthEndingAccess")]
        public RenderPassEndingAccess DepthEndingAccess;

        [NativeName("Type", "D3D12_RENDER_PASS_ENDING_ACCESS")]
        [NativeName("Type.Name", "D3D12_RENDER_PASS_ENDING_ACCESS")]
        [NativeName("Name", "StencilEndingAccess")]
        public RenderPassEndingAccess StencilEndingAccess;
    }
}
