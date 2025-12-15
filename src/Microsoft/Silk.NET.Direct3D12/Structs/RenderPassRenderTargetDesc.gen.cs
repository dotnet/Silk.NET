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
    [NativeName("Name", "D3D12_RENDER_PASS_RENDER_TARGET_DESC")]
    public unsafe partial struct RenderPassRenderTargetDesc
    {
        public RenderPassRenderTargetDesc
        (
            CpuDescriptorHandle? cpuDescriptor = null,
            RenderPassBeginningAccess? beginningAccess = null,
            RenderPassEndingAccess? endingAccess = null
        ) : this()
        {
            if (cpuDescriptor is not null)
            {
                CpuDescriptor = cpuDescriptor.Value;
            }

            if (beginningAccess is not null)
            {
                BeginningAccess = beginningAccess.Value;
            }

            if (endingAccess is not null)
            {
                EndingAccess = endingAccess.Value;
            }
        }


        [NativeName("Type", "D3D12_CPU_DESCRIPTOR_HANDLE")]
        [NativeName("Type.Name", "D3D12_CPU_DESCRIPTOR_HANDLE")]
        [NativeName("Name", "cpuDescriptor")]
        public CpuDescriptorHandle CpuDescriptor;

        [NativeName("Type", "D3D12_RENDER_PASS_BEGINNING_ACCESS")]
        [NativeName("Type.Name", "D3D12_RENDER_PASS_BEGINNING_ACCESS")]
        [NativeName("Name", "BeginningAccess")]
        public RenderPassBeginningAccess BeginningAccess;

        [NativeName("Type", "D3D12_RENDER_PASS_ENDING_ACCESS")]
        [NativeName("Type.Name", "D3D12_RENDER_PASS_ENDING_ACCESS")]
        [NativeName("Name", "EndingAccess")]
        public RenderPassEndingAccess EndingAccess;
    }
}
