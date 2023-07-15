// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1shader.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D3D10_SHADER_DEBUG_INPUT_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INPUT_INFO"]/*'/>
public partial struct D3D10_SHADER_DEBUG_INPUT_INFO
{
    /// <include file='D3D10_SHADER_DEBUG_INPUT_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INPUT_INFO.Var"]/*'/>
    public uint Var;
    /// <include file='D3D10_SHADER_DEBUG_INPUT_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INPUT_INFO.InitialRegisterSet"]/*'/>
    public D3D10_SHADER_DEBUG_REGTYPE InitialRegisterSet;
    /// <include file='D3D10_SHADER_DEBUG_INPUT_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INPUT_INFO.InitialBank"]/*'/>
    public uint InitialBank;
    /// <include file='D3D10_SHADER_DEBUG_INPUT_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INPUT_INFO.InitialRegister"]/*'/>
    public uint InitialRegister;
    /// <include file='D3D10_SHADER_DEBUG_INPUT_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INPUT_INFO.InitialComponent"]/*'/>
    public uint InitialComponent;
    /// <include file='D3D10_SHADER_DEBUG_INPUT_INFO.xml' path='doc/member[@name="D3D10_SHADER_DEBUG_INPUT_INFO.InitialValue"]/*'/>
    public uint InitialValue;
}