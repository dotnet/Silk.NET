// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D12
{
    [Flags]
    [NativeName("Name", "D3D12_FORMAT_SUPPORT1")]
    public enum FormatSupport1 : int
    {
        [Obsolete("Deprecated in favour of \"None\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_NONE")]
        FormatSupport1None = 0x0,
        [Obsolete("Deprecated in favour of \"Buffer\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_BUFFER")]
        FormatSupport1Buffer = 0x1,
        [Obsolete("Deprecated in favour of \"IAVertexBuffer\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_IA_VERTEX_BUFFER")]
        FormatSupport1IAVertexBuffer = 0x2,
        [Obsolete("Deprecated in favour of \"IAIndexBuffer\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_IA_INDEX_BUFFER")]
        FormatSupport1IAIndexBuffer = 0x4,
        [Obsolete("Deprecated in favour of \"SOBuffer\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_SO_BUFFER")]
        FormatSupport1SOBuffer = 0x8,
        [Obsolete("Deprecated in favour of \"Texture1D\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_TEXTURE1D")]
        FormatSupport1Texture1D = 0x10,
        [Obsolete("Deprecated in favour of \"Texture2D\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_TEXTURE2D")]
        FormatSupport1Texture2D = 0x20,
        [Obsolete("Deprecated in favour of \"Texture3D\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_TEXTURE3D")]
        FormatSupport1Texture3D = 0x40,
        [Obsolete("Deprecated in favour of \"Texturecube\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_TEXTURECUBE")]
        FormatSupport1Texturecube = 0x80,
        [Obsolete("Deprecated in favour of \"ShaderLoad\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_SHADER_LOAD")]
        FormatSupport1ShaderLoad = 0x100,
        [Obsolete("Deprecated in favour of \"ShaderSample\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE")]
        FormatSupport1ShaderSample = 0x200,
        [Obsolete("Deprecated in favour of \"ShaderSampleComparison\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE_COMPARISON")]
        FormatSupport1ShaderSampleComparison = 0x400,
        [Obsolete("Deprecated in favour of \"ShaderSampleMonoText\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE_MONO_TEXT")]
        FormatSupport1ShaderSampleMonoText = 0x800,
        [Obsolete("Deprecated in favour of \"Mip\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_MIP")]
        FormatSupport1Mip = 0x1000,
        [Obsolete("Deprecated in favour of \"RenderTarget\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_RENDER_TARGET")]
        FormatSupport1RenderTarget = 0x4000,
        [Obsolete("Deprecated in favour of \"Blendable\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_BLENDABLE")]
        FormatSupport1Blendable = 0x8000,
        [Obsolete("Deprecated in favour of \"DepthStencil\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_DEPTH_STENCIL")]
        FormatSupport1DepthStencil = 0x10000,
        [Obsolete("Deprecated in favour of \"MultisampleResolve\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_MULTISAMPLE_RESOLVE")]
        FormatSupport1MultisampleResolve = 0x40000,
        [Obsolete("Deprecated in favour of \"Display\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_DISPLAY")]
        FormatSupport1Display = 0x80000,
        [Obsolete("Deprecated in favour of \"CastWithinBitLayout\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_CAST_WITHIN_BIT_LAYOUT")]
        FormatSupport1CastWithinBitLayout = 0x100000,
        [Obsolete("Deprecated in favour of \"MultisampleRendertarget\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_MULTISAMPLE_RENDERTARGET")]
        FormatSupport1MultisampleRendertarget = 0x200000,
        [Obsolete("Deprecated in favour of \"MultisampleLoad\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_MULTISAMPLE_LOAD")]
        FormatSupport1MultisampleLoad = 0x400000,
        [Obsolete("Deprecated in favour of \"ShaderGather\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_SHADER_GATHER")]
        FormatSupport1ShaderGather = 0x800000,
        [Obsolete("Deprecated in favour of \"BackBufferCast\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_BACK_BUFFER_CAST")]
        FormatSupport1BackBufferCast = 0x1000000,
        [Obsolete("Deprecated in favour of \"TypedUnorderedAccessView\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_TYPED_UNORDERED_ACCESS_VIEW")]
        FormatSupport1TypedUnorderedAccessView = 0x2000000,
        [Obsolete("Deprecated in favour of \"ShaderGatherComparison\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_SHADER_GATHER_COMPARISON")]
        FormatSupport1ShaderGatherComparison = 0x4000000,
        [Obsolete("Deprecated in favour of \"DecoderOutput\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_DECODER_OUTPUT")]
        FormatSupport1DecoderOutput = 0x8000000,
        [Obsolete("Deprecated in favour of \"VideoProcessorOutput\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_VIDEO_PROCESSOR_OUTPUT")]
        FormatSupport1VideoProcessorOutput = 0x10000000,
        [Obsolete("Deprecated in favour of \"VideoProcessorInput\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_VIDEO_PROCESSOR_INPUT")]
        FormatSupport1VideoProcessorInput = 0x20000000,
        [Obsolete("Deprecated in favour of \"VideoEncoder\"")]
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_VIDEO_ENCODER")]
        FormatSupport1VideoEncoder = 0x40000000,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_NONE")]
        None = 0x0,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_BUFFER")]
        Buffer = 0x1,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_IA_VERTEX_BUFFER")]
        IAVertexBuffer = 0x2,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_IA_INDEX_BUFFER")]
        IAIndexBuffer = 0x4,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_SO_BUFFER")]
        SOBuffer = 0x8,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_TEXTURE1D")]
        Texture1D = 0x10,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_TEXTURE2D")]
        Texture2D = 0x20,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_TEXTURE3D")]
        Texture3D = 0x40,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_TEXTURECUBE")]
        Texturecube = 0x80,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_SHADER_LOAD")]
        ShaderLoad = 0x100,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE")]
        ShaderSample = 0x200,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE_COMPARISON")]
        ShaderSampleComparison = 0x400,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_SHADER_SAMPLE_MONO_TEXT")]
        ShaderSampleMonoText = 0x800,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_MIP")]
        Mip = 0x1000,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_RENDER_TARGET")]
        RenderTarget = 0x4000,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_BLENDABLE")]
        Blendable = 0x8000,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_DEPTH_STENCIL")]
        DepthStencil = 0x10000,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_MULTISAMPLE_RESOLVE")]
        MultisampleResolve = 0x40000,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_DISPLAY")]
        Display = 0x80000,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_CAST_WITHIN_BIT_LAYOUT")]
        CastWithinBitLayout = 0x100000,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_MULTISAMPLE_RENDERTARGET")]
        MultisampleRendertarget = 0x200000,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_MULTISAMPLE_LOAD")]
        MultisampleLoad = 0x400000,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_SHADER_GATHER")]
        ShaderGather = 0x800000,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_BACK_BUFFER_CAST")]
        BackBufferCast = 0x1000000,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_TYPED_UNORDERED_ACCESS_VIEW")]
        TypedUnorderedAccessView = 0x2000000,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_SHADER_GATHER_COMPARISON")]
        ShaderGatherComparison = 0x4000000,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_DECODER_OUTPUT")]
        DecoderOutput = 0x8000000,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_VIDEO_PROCESSOR_OUTPUT")]
        VideoProcessorOutput = 0x10000000,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_VIDEO_PROCESSOR_INPUT")]
        VideoProcessorInput = 0x20000000,
        [NativeName("Name", "D3D12_FORMAT_SUPPORT1_VIDEO_ENCODER")]
        VideoEncoder = 0x40000000,
    }
}
