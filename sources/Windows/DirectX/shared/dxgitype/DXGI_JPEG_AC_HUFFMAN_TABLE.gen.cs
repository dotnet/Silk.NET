// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/dxgitype.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='DXGI_JPEG_AC_HUFFMAN_TABLE.xml' path='doc/member[@name="DXGI_JPEG_AC_HUFFMAN_TABLE"]/*'/>
public unsafe partial struct DXGI_JPEG_AC_HUFFMAN_TABLE
{
    /// <include file='DXGI_JPEG_AC_HUFFMAN_TABLE.xml' path='doc/member[@name="DXGI_JPEG_AC_HUFFMAN_TABLE.CodeCounts"]/*'/>
    [NativeTypeName("BYTE[16]")]
    public fixed byte CodeCounts[16];
    /// <include file='DXGI_JPEG_AC_HUFFMAN_TABLE.xml' path='doc/member[@name="DXGI_JPEG_AC_HUFFMAN_TABLE.CodeValues"]/*'/>
    [NativeTypeName("BYTE[162]")]
    public fixed byte CodeValues[162];
}