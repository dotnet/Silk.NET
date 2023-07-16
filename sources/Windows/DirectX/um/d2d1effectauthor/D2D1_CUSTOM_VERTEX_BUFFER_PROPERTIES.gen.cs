// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES.xml' path='doc/member[@name="D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES"]/*'/>
public unsafe partial struct D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES
{
    /// <include file='D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES.xml' path='doc/member[@name="D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES.shaderBufferWithInputSignature"]/*'/>
    [NativeTypeName("const BYTE *")]
    public byte* shaderBufferWithInputSignature;
    /// <include file='D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES.xml' path='doc/member[@name="D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES.shaderBufferSize"]/*'/>
    [NativeTypeName("UINT32")]
    public uint shaderBufferSize;
    /// <include file='D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES.xml' path='doc/member[@name="D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES.inputElements"]/*'/>
    [NativeTypeName("const D2D1_INPUT_ELEMENT_DESC *")]
    public D2D1_INPUT_ELEMENT_DESC* inputElements;
    /// <include file='D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES.xml' path='doc/member[@name="D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES.elementCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint elementCount;
    /// <include file='D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES.xml' path='doc/member[@name="D2D1_CUSTOM_VERTEX_BUFFER_PROPERTIES.stride"]/*'/>
    [NativeTypeName("UINT32")]
    public uint stride;
}