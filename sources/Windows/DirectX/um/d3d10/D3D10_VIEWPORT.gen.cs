// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D10_VIEWPORT.xml' path='doc/member[@name="D3D10_VIEWPORT"]/*'/>
public partial struct D3D10_VIEWPORT
{
    /// <include file='D3D10_VIEWPORT.xml' path='doc/member[@name="D3D10_VIEWPORT.TopLeftX"]/*'/>
    public int TopLeftX;
    /// <include file='D3D10_VIEWPORT.xml' path='doc/member[@name="D3D10_VIEWPORT.TopLeftY"]/*'/>
    public int TopLeftY;
    /// <include file='D3D10_VIEWPORT.xml' path='doc/member[@name="D3D10_VIEWPORT.Width"]/*'/>
    public uint Width;
    /// <include file='D3D10_VIEWPORT.xml' path='doc/member[@name="D3D10_VIEWPORT.Height"]/*'/>
    public uint Height;
    /// <include file='D3D10_VIEWPORT.xml' path='doc/member[@name="D3D10_VIEWPORT.MinDepth"]/*'/>
    public float MinDepth;
    /// <include file='D3D10_VIEWPORT.xml' path='doc/member[@name="D3D10_VIEWPORT.MaxDepth"]/*'/>
    public float MaxDepth;
}