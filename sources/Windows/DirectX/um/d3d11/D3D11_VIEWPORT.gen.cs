// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_VIEWPORT.xml' path='doc/member[@name="D3D11_VIEWPORT"]/*'/>
public partial struct D3D11_VIEWPORT
{
    /// <include file='D3D11_VIEWPORT.xml' path='doc/member[@name="D3D11_VIEWPORT.TopLeftX"]/*'/>
    public float TopLeftX;
    /// <include file='D3D11_VIEWPORT.xml' path='doc/member[@name="D3D11_VIEWPORT.TopLeftY"]/*'/>
    public float TopLeftY;
    /// <include file='D3D11_VIEWPORT.xml' path='doc/member[@name="D3D11_VIEWPORT.Width"]/*'/>
    public float Width;
    /// <include file='D3D11_VIEWPORT.xml' path='doc/member[@name="D3D11_VIEWPORT.Height"]/*'/>
    public float Height;
    /// <include file='D3D11_VIEWPORT.xml' path='doc/member[@name="D3D11_VIEWPORT.MinDepth"]/*'/>
    public float MinDepth;
    /// <include file='D3D11_VIEWPORT.xml' path='doc/member[@name="D3D11_VIEWPORT.MaxDepth"]/*'/>
    public float MaxDepth;
}