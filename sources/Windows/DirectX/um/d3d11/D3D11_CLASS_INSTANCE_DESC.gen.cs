// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D11_CLASS_INSTANCE_DESC.xml' path='doc/member[@name="D3D11_CLASS_INSTANCE_DESC"]/*'/>
public partial struct D3D11_CLASS_INSTANCE_DESC
{
    /// <include file='D3D11_CLASS_INSTANCE_DESC.xml' path='doc/member[@name="D3D11_CLASS_INSTANCE_DESC.InstanceId"]/*'/>
    public uint InstanceId;
    /// <include file='D3D11_CLASS_INSTANCE_DESC.xml' path='doc/member[@name="D3D11_CLASS_INSTANCE_DESC.InstanceIndex"]/*'/>
    public uint InstanceIndex;
    /// <include file='D3D11_CLASS_INSTANCE_DESC.xml' path='doc/member[@name="D3D11_CLASS_INSTANCE_DESC.TypeId"]/*'/>
    public uint TypeId;
    /// <include file='D3D11_CLASS_INSTANCE_DESC.xml' path='doc/member[@name="D3D11_CLASS_INSTANCE_DESC.ConstantBuffer"]/*'/>
    public uint ConstantBuffer;
    /// <include file='D3D11_CLASS_INSTANCE_DESC.xml' path='doc/member[@name="D3D11_CLASS_INSTANCE_DESC.BaseConstantBufferOffset"]/*'/>
    public uint BaseConstantBufferOffset;
    /// <include file='D3D11_CLASS_INSTANCE_DESC.xml' path='doc/member[@name="D3D11_CLASS_INSTANCE_DESC.BaseTexture"]/*'/>
    public uint BaseTexture;
    /// <include file='D3D11_CLASS_INSTANCE_DESC.xml' path='doc/member[@name="D3D11_CLASS_INSTANCE_DESC.BaseSampler"]/*'/>
    public uint BaseSampler;
    /// <include file='D3D11_CLASS_INSTANCE_DESC.xml' path='doc/member[@name="D3D11_CLASS_INSTANCE_DESC.Created"]/*'/>
    public BOOL Created;
}