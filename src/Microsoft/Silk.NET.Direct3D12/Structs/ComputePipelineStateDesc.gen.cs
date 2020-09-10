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
    [NativeName("Name", "D3D12_COMPUTE_PIPELINE_STATE_DESC")]
    public unsafe partial struct ComputePipelineStateDesc
    {
        public ComputePipelineStateDesc
        (
            ID3D12RootSignature* pRootSignature = default,
            ShaderBytecode cS = default,
            uint nodeMask = default,
            CachedPipelineState cachedPSO = default,
            PipelineStateFlags flags = default
        )
        {
            PRootSignature = pRootSignature;
            CS = cS;
            NodeMask = nodeMask;
            CachedPSO = cachedPSO;
            Flags = flags;
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
