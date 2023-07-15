// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from d3dcommon.h in microsoft/DirectX-Headers tag v1.606.4
// Original source is Copyright © Microsoft. Licensed under the MIT license
namespace TerraFX.Interop.DirectX;
/// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE"]/*'/>
public enum D3D_REGISTER_COMPONENT_TYPE
{
    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_UNKNOWN"]/*'/>
    D3D_REGISTER_COMPONENT_UNKNOWN = 0,
    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_UINT32"]/*'/>
    D3D_REGISTER_COMPONENT_UINT32 = 1,
    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_SINT32"]/*'/>
    D3D_REGISTER_COMPONENT_SINT32 = 2,
    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D_REGISTER_COMPONENT_FLOAT32"]/*'/>
    D3D_REGISTER_COMPONENT_FLOAT32 = 3,
    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_UNKNOWN"]/*'/>
    D3D10_REGISTER_COMPONENT_UNKNOWN = D3D_REGISTER_COMPONENT_UNKNOWN,
    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_UINT32"]/*'/>
    D3D10_REGISTER_COMPONENT_UINT32 = D3D_REGISTER_COMPONENT_UINT32,
    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_SINT32"]/*'/>
    D3D10_REGISTER_COMPONENT_SINT32 = D3D_REGISTER_COMPONENT_SINT32,
    /// <include file='D3D_REGISTER_COMPONENT_TYPE.xml' path='doc/member[@name="D3D_REGISTER_COMPONENT_TYPE.D3D10_REGISTER_COMPONENT_FLOAT32"]/*'/>
    D3D10_REGISTER_COMPONENT_FLOAT32 = D3D_REGISTER_COMPONENT_FLOAT32,
}