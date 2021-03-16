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
    [NativeName("Name", "D3D12_COMPUTE_PIPELINE_STATE_DESC")]
    public unsafe partial struct ComputePipelineStateDesc
    {
        public ComputePipelineStateDesc
        (
            ID3D12RootSignature* pRootSignature = null,
            ShaderBytecode? cS = null,
            uint? nodeMask = null,
            CachedPipelineState? cachedPSO = null,
            PipelineStateFlags? flags = null
        ) : this()
        {
            if (pRootSignature is not null)
            {
                PRootSignature = pRootSignature;
            }

            if (cS is not null)
            {
                CS = cS.Value;
            }

            if (nodeMask is not null)
            {
                NodeMask = nodeMask.Value;
            }

            if (cachedPSO is not null)
            {
                CachedPSO = cachedPSO.Value;
            }

            if (flags is not null)
            {
                Flags = flags.Value;
            }
        }


        [NativeName("Type", "ID3D12RootSignature *")]
        [NativeName("Type.Name", "ID3D12RootSignature *")]
        [NativeName("Name", "pRootSignature")]
        public ID3D12RootSignature* PRootSignature;

        [NativeName("Type", "D3D12_SHADER_BYTECODE")]
        [NativeName("Type.Name", "D3D12_SHADER_BYTECODE")]
        [NativeName("Name", "CS")]
        public ShaderBytecode CS;

        [NativeName("Type", "UINT")]
        [NativeName("Type.Name", "UINT")]
        [NativeName("Name", "NodeMask")]
        public uint NodeMask;

        [NativeName("Type", "D3D12_CACHED_PIPELINE_STATE")]
        [NativeName("Type.Name", "D3D12_CACHED_PIPELINE_STATE")]
        [NativeName("Name", "CachedPSO")]
        public CachedPipelineState CachedPSO;

        [NativeName("Type", "D3D12_PIPELINE_STATE_FLAGS")]
        [NativeName("Type.Name", "D3D12_PIPELINE_STATE_FLAGS")]
        [NativeName("Name", "Flags")]
        public PipelineStateFlags Flags;
    }
}
