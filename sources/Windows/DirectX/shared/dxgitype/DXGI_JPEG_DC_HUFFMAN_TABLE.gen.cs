// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='DXGI_JPEG_DC_HUFFMAN_TABLE.xml' path='doc/member[@name="DXGI_JPEG_DC_HUFFMAN_TABLE"]/*'/>
public unsafe partial struct DXGI_JPEG_DC_HUFFMAN_TABLE
{
    /// <include file='DXGI_JPEG_DC_HUFFMAN_TABLE.xml' path='doc/member[@name="DXGI_JPEG_DC_HUFFMAN_TABLE.CodeCounts"]/*'/>
    [NativeTypeName("BYTE[12]")]
    public fixed byte CodeCounts[12];
    /// <include file='DXGI_JPEG_DC_HUFFMAN_TABLE.xml' path='doc/member[@name="DXGI_JPEG_DC_HUFFMAN_TABLE.CodeValues"]/*'/>
    [NativeTypeName("BYTE[12]")]
    public fixed byte CodeValues[12];
}