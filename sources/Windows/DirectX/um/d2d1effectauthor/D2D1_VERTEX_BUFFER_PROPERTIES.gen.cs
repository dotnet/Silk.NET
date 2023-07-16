// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_VERTEX_BUFFER_PROPERTIES.xml' path='doc/member[@name="D2D1_VERTEX_BUFFER_PROPERTIES"]/*'/>
public unsafe partial struct D2D1_VERTEX_BUFFER_PROPERTIES
{
    /// <include file='D2D1_VERTEX_BUFFER_PROPERTIES.xml' path='doc/member[@name="D2D1_VERTEX_BUFFER_PROPERTIES.inputCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint inputCount;
    /// <include file='D2D1_VERTEX_BUFFER_PROPERTIES.xml' path='doc/member[@name="D2D1_VERTEX_BUFFER_PROPERTIES.usage"]/*'/>
    public D2D1_VERTEX_USAGE usage;
    /// <include file='D2D1_VERTEX_BUFFER_PROPERTIES.xml' path='doc/member[@name="D2D1_VERTEX_BUFFER_PROPERTIES.data"]/*'/>
    [NativeTypeName("const BYTE *")]
    public byte* data;
    /// <include file='D2D1_VERTEX_BUFFER_PROPERTIES.xml' path='doc/member[@name="D2D1_VERTEX_BUFFER_PROPERTIES.byteWidth"]/*'/>
    [NativeTypeName("UINT32")]
    public uint byteWidth;
}