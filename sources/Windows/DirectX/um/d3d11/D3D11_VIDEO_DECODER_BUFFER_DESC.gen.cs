// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct D3D11_VIDEO_DECODER_BUFFER_DESC
{
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC.BufferType"]/*'/>
    public D3D11_VIDEO_DECODER_BUFFER_TYPE BufferType;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC.BufferIndex"]/*'/>
    public uint BufferIndex;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC.DataOffset"]/*'/>
    public uint DataOffset;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC.DataSize"]/*'/>
    public uint DataSize;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC.FirstMBaddress"]/*'/>
    public uint FirstMBaddress;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC.NumMBsInBuffer"]/*'/>
    public uint NumMBsInBuffer;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC.Width"]/*'/>
    public uint Width;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC.Height"]/*'/>
    public uint Height;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC.Stride"]/*'/>
    public uint Stride;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC.ReservedBits"]/*'/>
    public uint ReservedBits;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC.pIV"]/*'/>
    public void* pIV;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC.IVSize"]/*'/>
    public uint IVSize;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC.PartialEncryption"]/*'/>
    public BOOL PartialEncryption;
    /// <include file='D3D11_VIDEO_DECODER_BUFFER_DESC.xml' path='doc/member[@name="D3D11_VIDEO_DECODER_BUFFER_DESC.EncryptedBlockInfo"]/*'/>
    public D3D11_ENCRYPTED_BLOCK_INFO EncryptedBlockInfo;
}