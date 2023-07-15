// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11_4.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC2.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC2"]/*'/>
public unsafe partial struct D3D11_VIDEO_DECODER_BUFFER_DESC2
{
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC2.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC2.BufferType"]/*'/>
    public D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC2.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC2.DataOffset"]/*'/>
    public uint DataOffset;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC2.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC2.DataSize"]/*'/>
    public uint DataSize;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC2.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC2.pIV"]/*'/>
    public void* pIV;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC2.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC2.IVSize"]/*'/>
    public uint IVSize;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC2.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC2.pSubSampleMappingBlock"]/*'/>
    public D3D11_VIDEO_DECODER_SUB_SAMPLE_MAPPING_BLOCK* pSubSampleMappingBlock;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC2.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC2.SubSampleMappingCount"]/*'/>
    public uint SubSampleMappingCount;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC2.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC2.cBlocksStripeEncrypted"]/*'/>
    public uint cBlocksStripeEncrypted;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC2.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC2.cBlocksStripeClear"]/*'/>
    public uint cBlocksStripeClear;
}