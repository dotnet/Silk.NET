// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D2D1_RESOURCE_TEXTURE_PROPERTIES.xml' path='doc/member[@name="D2D1_RESOURCE_TEXTURE_PROPERTIES"]/*'/>
public unsafe partial struct D2D1_RESOURCE_TEXTURE_PROPERTIES
{
    /// <include file='D2D1_RESOURCE_TEXTURE_PROPERTIES.xml' path='doc/member[@name="D2D1_RESOURCE_TEXTURE_PROPERTIES.extents"]/*'/>
    [NativeTypeName("const UINT32 *")]
    public uint* extents;
    /// <include file='D2D1_RESOURCE_TEXTURE_PROPERTIES.xml' path='doc/member[@name="D2D1_RESOURCE_TEXTURE_PROPERTIES.dimensions"]/*'/>
    [NativeTypeName("UINT32")]
    public uint dimensions;
    /// <include file='D2D1_RESOURCE_TEXTURE_PROPERTIES.xml' path='doc/member[@name="D2D1_RESOURCE_TEXTURE_PROPERTIES.bufferPrecision"]/*'/>
    public D2D1_BUFFER_PRECISION bufferPrecision;
    /// <include file='D2D1_RESOURCE_TEXTURE_PROPERTIES.xml' path='doc/member[@name="D2D1_RESOURCE_TEXTURE_PROPERTIES.channelDepth"]/*'/>
    public D2D1_CHANNEL_DEPTH channelDepth;
    /// <include file='D2D1_RESOURCE_TEXTURE_PROPERTIES.xml' path='doc/member[@name="D2D1_RESOURCE_TEXTURE_PROPERTIES.filter"]/*'/>
    public D2D1_FILTER filter;
    /// <include file='D2D1_RESOURCE_TEXTURE_PROPERTIES.xml' path='doc/member[@name="D2D1_RESOURCE_TEXTURE_PROPERTIES.extendModes"]/*'/>
    [NativeTypeName("const D2D1_EXTEND_MODE *")]
    public D2D1_EXTEND_MODE* extendModes;
}