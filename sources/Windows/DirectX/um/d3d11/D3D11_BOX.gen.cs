// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_BOX.xml' path='doc/member[@name="D3D11_BOX"]/*'/>
public partial struct D3D11_BOX
{
    /// <include file='D3D11_BOX.xml' path='doc/member[@name="D3D11_BOX.left"]/*'/>
    public uint left;
    /// <include file='D3D11_BOX.xml' path='doc/member[@name="D3D11_BOX.top"]/*'/>
    public uint top;
    /// <include file='D3D11_BOX.xml' path='doc/member[@name="D3D11_BOX.front"]/*'/>
    public uint front;
    /// <include file='D3D11_BOX.xml' path='doc/member[@name="D3D11_BOX.right"]/*'/>
    public uint right;
    /// <include file='D3D11_BOX.xml' path='doc/member[@name="D3D11_BOX.bottom"]/*'/>
    public uint bottom;
    /// <include file='D3D11_BOX.xml' path='doc/member[@name="D3D11_BOX.back"]/*'/>
    public uint back;
}