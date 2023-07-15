// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1effectauthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D2D1_VERTEX_RANGE.xml' path='doc/member[@name="D2D1_VERTEX_RANGE"]/*'/>
public partial struct D2D1_VERTEX_RANGE
{
    /// <include file='D2D1_VERTEX_RANGE.xml' path='doc/member[@name="D2D1_VERTEX_RANGE.startVertex"]/*'/>
    [NativeTypeName("UINT32")]
    public uint startVertex;
    /// <include file='D2D1_VERTEX_RANGE.xml' path='doc/member[@name="D2D1_VERTEX_RANGE.vertexCount"]/*'/>
    [NativeTypeName("UINT32")]
    public uint vertexCount;
}