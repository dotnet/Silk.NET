// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Direct3D11
{
    [Flags]
    [NativeName("Name", "D3D11_FORMAT_SUPPORT")]
    public enum FormatSupport : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"Buffer\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_BUFFER")]
        FormatSupportBuffer = 0x1,
        [Obsolete("Deprecated in favour of \"IAVertexBuffer\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_IA_VERTEX_BUFFER")]
        FormatSupportIAVertexBuffer = 0x2,
        [Obsolete("Deprecated in favour of \"IAIndexBuffer\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_IA_INDEX_BUFFER")]
        FormatSupportIAIndexBuffer = 0x4,
        [Obsolete("Deprecated in favour of \"SOBuffer\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SO_BUFFER")]
        FormatSupportSOBuffer = 0x8,
        [Obsolete("Deprecated in favour of \"Texture1D\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_TEXTURE1D")]
        FormatSupportTexture1D = 0x10,
        [Obsolete("Deprecated in favour of \"Texture2D\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_TEXTURE2D")]
        FormatSupportTexture2D = 0x20,
        [Obsolete("Deprecated in favour of \"Texture3D\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_TEXTURE3D")]
        FormatSupportTexture3D = 0x40,
        [Obsolete("Deprecated in favour of \"Texturecube\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_TEXTURECUBE")]
        FormatSupportTexturecube = 0x80,
        [Obsolete("Deprecated in favour of \"ShaderLoad\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_LOAD")]
        FormatSupportShaderLoad = 0x100,
        [Obsolete("Deprecated in favour of \"ShaderSample\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_SAMPLE")]
        FormatSupportShaderSample = 0x200,
        [Obsolete("Deprecated in favour of \"ShaderSampleComparison\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_SAMPLE_COMPARISON")]
        FormatSupportShaderSampleComparison = 0x400,
        [Obsolete("Deprecated in favour of \"ShaderSampleMonoText\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_SAMPLE_MONO_TEXT")]
        FormatSupportShaderSampleMonoText = 0x800,
        [Obsolete("Deprecated in favour of \"Mip\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_MIP")]
        FormatSupportMip = 0x1000,
        [Obsolete("Deprecated in favour of \"MipAutogen\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_MIP_AUTOGEN")]
        FormatSupportMipAutogen = 0x2000,
        [Obsolete("Deprecated in favour of \"RenderTarget\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_RENDER_TARGET")]
        FormatSupportRenderTarget = 0x4000,
        [Obsolete("Deprecated in favour of \"Blendable\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_BLENDABLE")]
        FormatSupportBlendable = 0x8000,
        [Obsolete("Deprecated in favour of \"DepthStencil\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_DEPTH_STENCIL")]
        FormatSupportDepthStencil = 0x10000,
        [Obsolete("Deprecated in favour of \"CpuLockable\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_CPU_LOCKABLE")]
        FormatSupportCpuLockable = 0x20000,
        [Obsolete("Deprecated in favour of \"MultisampleResolve\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_MULTISAMPLE_RESOLVE")]
        FormatSupportMultisampleResolve = 0x40000,
        [Obsolete("Deprecated in favour of \"Display\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_DISPLAY")]
        FormatSupportDisplay = 0x80000,
        [Obsolete("Deprecated in favour of \"CastWithinBitLayout\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_CAST_WITHIN_BIT_LAYOUT")]
        FormatSupportCastWithinBitLayout = 0x100000,
        [Obsolete("Deprecated in favour of \"MultisampleRendertarget\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_MULTISAMPLE_RENDERTARGET")]
        FormatSupportMultisampleRendertarget = 0x200000,
        [Obsolete("Deprecated in favour of \"MultisampleLoad\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_MULTISAMPLE_LOAD")]
        FormatSupportMultisampleLoad = 0x400000,
        [Obsolete("Deprecated in favour of \"ShaderGather\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_GATHER")]
        FormatSupportShaderGather = 0x800000,
        [Obsolete("Deprecated in favour of \"BackBufferCast\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_BACK_BUFFER_CAST")]
        FormatSupportBackBufferCast = 0x1000000,
        [Obsolete("Deprecated in favour of \"TypedUnorderedAccessView\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_TYPED_UNORDERED_ACCESS_VIEW")]
        FormatSupportTypedUnorderedAccessView = 0x2000000,
        [Obsolete("Deprecated in favour of \"ShaderGatherComparison\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_GATHER_COMPARISON")]
        FormatSupportShaderGatherComparison = 0x4000000,
        [Obsolete("Deprecated in favour of \"DecoderOutput\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_DECODER_OUTPUT")]
        FormatSupportDecoderOutput = 0x8000000,
        [Obsolete("Deprecated in favour of \"VideoProcessorOutput\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_VIDEO_PROCESSOR_OUTPUT")]
        FormatSupportVideoProcessorOutput = 0x10000000,
        [Obsolete("Deprecated in favour of \"VideoProcessorInput\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_VIDEO_PROCESSOR_INPUT")]
        FormatSupportVideoProcessorInput = 0x20000000,
        [Obsolete("Deprecated in favour of \"VideoEncoder\"")]
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_VIDEO_ENCODER")]
        FormatSupportVideoEncoder = 0x40000000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_BUFFER")]
        Buffer = 0x1,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_IA_VERTEX_BUFFER")]
        IAVertexBuffer = 0x2,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_IA_INDEX_BUFFER")]
        IAIndexBuffer = 0x4,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SO_BUFFER")]
        SOBuffer = 0x8,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_TEXTURE1D")]
        Texture1D = 0x10,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_TEXTURE2D")]
        Texture2D = 0x20,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_TEXTURE3D")]
        Texture3D = 0x40,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_TEXTURECUBE")]
        Texturecube = 0x80,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_LOAD")]
        ShaderLoad = 0x100,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_SAMPLE")]
        ShaderSample = 0x200,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_SAMPLE_COMPARISON")]
        ShaderSampleComparison = 0x400,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_SAMPLE_MONO_TEXT")]
        ShaderSampleMonoText = 0x800,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_MIP")]
        Mip = 0x1000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_MIP_AUTOGEN")]
        MipAutogen = 0x2000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_RENDER_TARGET")]
        RenderTarget = 0x4000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_BLENDABLE")]
        Blendable = 0x8000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_DEPTH_STENCIL")]
        DepthStencil = 0x10000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_CPU_LOCKABLE")]
        CpuLockable = 0x20000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_MULTISAMPLE_RESOLVE")]
        MultisampleResolve = 0x40000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_DISPLAY")]
        Display = 0x80000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_CAST_WITHIN_BIT_LAYOUT")]
        CastWithinBitLayout = 0x100000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_MULTISAMPLE_RENDERTARGET")]
        MultisampleRendertarget = 0x200000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_MULTISAMPLE_LOAD")]
        MultisampleLoad = 0x400000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_GATHER")]
        ShaderGather = 0x800000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_BACK_BUFFER_CAST")]
        BackBufferCast = 0x1000000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_TYPED_UNORDERED_ACCESS_VIEW")]
        TypedUnorderedAccessView = 0x2000000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_GATHER_COMPARISON")]
        ShaderGatherComparison = 0x4000000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_DECODER_OUTPUT")]
        DecoderOutput = 0x8000000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_VIDEO_PROCESSOR_OUTPUT")]
        VideoProcessorOutput = 0x10000000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_VIDEO_PROCESSOR_INPUT")]
        VideoProcessorInput = 0x20000000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_VIDEO_ENCODER")]
        VideoEncoder = 0x40000000,
    }
}
