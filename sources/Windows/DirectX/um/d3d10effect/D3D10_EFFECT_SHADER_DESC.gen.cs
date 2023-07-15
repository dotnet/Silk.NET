// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D10_EFFECT_SHADER_DESC.xml' path='doc/member[@name="D3D10_EFFECT_SHADER_DESC"]/*'/>
public unsafe partial struct D3D10_EFFECT_SHADER_DESC
{
    /// <include file='D3D10_EFFECT_SHADER_DESC.xml' path='doc/member[@name="D3D10_EFFECT_SHADER_DESC.pInputSignature"]/*'/>
    [NativeTypeName("const BYTE *")]
    public byte* pInputSignature;
    /// <include file='D3D10_EFFECT_SHADER_DESC.xml' path='doc/member[@name="D3D10_EFFECT_SHADER_DESC.IsInline"]/*'/>
    public BOOL IsInline;
    /// <include file='D3D10_EFFECT_SHADER_DESC.xml' path='doc/member[@name="D3D10_EFFECT_SHADER_DESC.pBytecode"]/*'/>
    [NativeTypeName("const BYTE *")]
    public byte* pBytecode;
    /// <include file='D3D10_EFFECT_SHADER_DESC.xml' path='doc/member[@name="D3D10_EFFECT_SHADER_DESC.BytecodeLength"]/*'/>
    public uint BytecodeLength;
    /// <include file='D3D10_EFFECT_SHADER_DESC.xml' path='doc/member[@name="D3D10_EFFECT_SHADER_DESC.SODecl"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* SODecl;
    /// <include file='D3D10_EFFECT_SHADER_DESC.xml' path='doc/member[@name="D3D10_EFFECT_SHADER_DESC.NumInputSignatureEntries"]/*'/>
    public uint NumInputSignatureEntries;
    /// <include file='D3D10_EFFECT_SHADER_DESC.xml' path='doc/member[@name="D3D10_EFFECT_SHADER_DESC.NumOutputSignatureEntries"]/*'/>
    public uint NumOutputSignatureEntries;
}