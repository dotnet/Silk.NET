// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.DirectX;
/// <include file='D3D10_TECHNIQUE_DESC.xml' path='doc/member[@name="D3D10_TECHNIQUE_DESC"]/*'/>
public unsafe partial struct D3D10_TECHNIQUE_DESC
{
    /// <include file='D3D10_TECHNIQUE_DESC.xml' path='doc/member[@name="D3D10_TECHNIQUE_DESC.Name"]/*'/>
    [NativeTypeName("LPCSTR")]
    public sbyte* Name;
    /// <include file='D3D10_TECHNIQUE_DESC.xml' path='doc/member[@name="D3D10_TECHNIQUE_DESC.Passes"]/*'/>
    public uint Passes;
    /// <include file='D3D10_TECHNIQUE_DESC.xml' path='doc/member[@name="D3D10_TECHNIQUE_DESC.Annotations"]/*'/>
    public uint Annotations;
}