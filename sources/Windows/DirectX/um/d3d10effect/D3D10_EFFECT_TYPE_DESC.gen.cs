// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.DirectX;
/// <include file='D3D10_EFFECT_TYPE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_TYPE_DESC"]/*'/>
public unsafe partial struct D3D10_EFFECT_TYPE_DESC
{
    /// <include file='D3D10_EFFECT_TYPE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_TYPE_DESC.TypeName"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* TypeName;
    /// <include file='D3D10_EFFECT_TYPE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_TYPE_DESC.Class"]/*'/>
    [NativeTypeName("D3D10_SHADER_VARIABLE_CLASS")]
    public D3D_SHADER_VARIABLE_CLASS Class;
    /// <include file='D3D10_EFFECT_TYPE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_TYPE_DESC.Type"]/*'/>
    [NativeTypeName("D3D10_SHADER_VARIABLE_TYPE")]
    public D3D_SHADER_VARIABLE_TYPE Type;
    /// <include file='D3D10_EFFECT_TYPE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_TYPE_DESC.Elements"]/*'/>
    public uint Elements;
    /// <include file='D3D10_EFFECT_TYPE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_TYPE_DESC.Members"]/*'/>
    public uint Members;
    /// <include file='D3D10_EFFECT_TYPE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_TYPE_DESC.Rows"]/*'/>
    public uint Rows;
    /// <include file='D3D10_EFFECT_TYPE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_TYPE_DESC.Columns"]/*'/>
    public uint Columns;
    /// <include file='D3D10_EFFECT_TYPE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_TYPE_DESC.PackedSize"]/*'/>
    public uint PackedSize;
    /// <include file='D3D10_EFFECT_TYPE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_TYPE_DESC.UnpackedSize"]/*'/>
    public uint UnpackedSize;
    /// <include file='D3D10_EFFECT_TYPE_DESC.xml' path='doc/member[@name="D3D10_EFFECT_TYPE_DESC.Stride"]/*'/>
    public uint Stride;
}