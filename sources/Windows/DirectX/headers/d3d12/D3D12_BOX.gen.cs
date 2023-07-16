// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace Silk.NET.DirectX;
/// <include file='D3D12_BOX.xml' path='doc/member[@name="D3D12_BOX"]/*'/>
public partial struct D3D12_BOX
{
    /// <include file='D3D12_BOX.xml' path='doc/member[@name="D3D12_BOX.left"]/*'/>
    public uint left;
    /// <include file='D3D12_BOX.xml' path='doc/member[@name="D3D12_BOX.top"]/*'/>
    public uint top;
    /// <include file='D3D12_BOX.xml' path='doc/member[@name="D3D12_BOX.front"]/*'/>
    public uint front;
    /// <include file='D3D12_BOX.xml' path='doc/member[@name="D3D12_BOX.right"]/*'/>
    public uint right;
    /// <include file='D3D12_BOX.xml' path='doc/member[@name="D3D12_BOX.bottom"]/*'/>
    public uint bottom;
    /// <include file='D3D12_BOX.xml' path='doc/member[@name="D3D12_BOX.back"]/*'/>
    public uint back;
}