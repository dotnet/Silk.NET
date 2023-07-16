// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC1.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC1"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct D3D11_VIDEO_DECODER_BUFFER_DESC1
{
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC1.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC1.BufferType"]/*'/>
    public D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC1.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC1.DataOffset"]/*'/>
    public uint DataOffset;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC1.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC1.DataSize"]/*'/>
    public uint DataSize;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC1.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC1.pIV"]/*'/>
    public void* pIV;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC1.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC1.IVSize"]/*'/>
    public uint IVSize;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC1.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC1.pSubSampleMappingBlock"]/*'/>
    public D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK* pSubSampleMappingBlock;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC1.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC1.SubSampleMappingCount"]/*'/>
    public uint SubSampleMappingCount;
}