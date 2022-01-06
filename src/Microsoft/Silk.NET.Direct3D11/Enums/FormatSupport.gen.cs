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
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_BUFFER")]
        FormatSupportBuffer = 0x1,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_IA_VERTEX_BUFFER")]
        FormatSupportIAVertexBuffer = 0x2,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_IA_INDEX_BUFFER")]
        FormatSupportIAIndexBuffer = 0x4,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SO_BUFFER")]
        FormatSupportSOBuffer = 0x8,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_TEXTURE1D")]
        FormatSupportTexture1D = 0x10,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_TEXTURE2D")]
        FormatSupportTexture2D = 0x20,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_TEXTURE3D")]
        FormatSupportTexture3D = 0x40,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_TEXTURECUBE")]
        FormatSupportTexturecube = 0x80,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_LOAD")]
        FormatSupportShaderLoad = 0x100,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_SAMPLE")]
        FormatSupportShaderSample = 0x200,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_SAMPLE_COMPARISON")]
        FormatSupportShaderSampleComparison = 0x400,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_SAMPLE_MONO_TEXT")]
        FormatSupportShaderSampleMonoText = 0x800,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_MIP")]
        FormatSupportMip = 0x1000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_MIP_AUTOGEN")]
        FormatSupportMipAutogen = 0x2000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_RENDER_TARGET")]
        FormatSupportRenderTarget = 0x4000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_BLENDABLE")]
        FormatSupportBlendable = 0x8000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_DEPTH_STENCIL")]
        FormatSupportDepthStencil = 0x10000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_CPU_LOCKABLE")]
        FormatSupportCpuLockable = 0x20000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_MULTISAMPLE_RESOLVE")]
        FormatSupportMultisampleResolve = 0x40000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_DISPLAY")]
        FormatSupportDisplay = 0x80000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_CAST_WITHIN_BIT_LAYOUT")]
        FormatSupportCastWithinBitLayout = 0x100000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_MULTISAMPLE_RENDERTARGET")]
        FormatSupportMultisampleRendertarget = 0x200000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_MULTISAMPLE_LOAD")]
        FormatSupportMultisampleLoad = 0x400000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_GATHER")]
        FormatSupportShaderGather = 0x800000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_BACK_BUFFER_CAST")]
        FormatSupportBackBufferCast = 0x1000000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_TYPED_UNORDERED_ACCESS_VIEW")]
        FormatSupportTypedUnorderedAccessView = 0x2000000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_SHADER_GATHER_COMPARISON")]
        FormatSupportShaderGatherComparison = 0x4000000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_DECODER_OUTPUT")]
        FormatSupportDecoderOutput = 0x8000000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_VIDEO_PROCESSOR_OUTPUT")]
        FormatSupportVideoProcessorOutput = 0x10000000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_VIDEO_PROCESSOR_INPUT")]
        FormatSupportVideoProcessorInput = 0x20000000,
        [NativeName("Name", "D3D11_FORMAT_SUPPORT_VIDEO_ENCODER")]
        FormatSupportVideoEncoder = 0x40000000,
    }
}
