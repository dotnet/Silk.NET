// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10effect.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;
/// <include file='D3D10_EFFECT_DESC.xml' path='doc/member[@name="D3D10_EFFECT_DESC"]/*'/>
public partial struct D3D10_EFFECT_DESC
{
    /// <include file='D3D10_EFFECT_DESC.xml' path='doc/member[@name="D3D10_EFFECT_DESC.IsChildEffect"]/*'/>
    public BOOL IsChildEffect;
    /// <include file='D3D10_EFFECT_DESC.xml' path='doc/member[@name="D3D10_EFFECT_DESC.ConstantBuffers"]/*'/>
    public uint ConstantBuffers;
    /// <include file='D3D10_EFFECT_DESC.xml' path='doc/member[@name="D3D10_EFFECT_DESC.SharedConstantBuffers"]/*'/>
    public uint SharedConstantBuffers;
    /// <include file='D3D10_EFFECT_DESC.xml' path='doc/member[@name="D3D10_EFFECT_DESC.GlobalVariables"]/*'/>
    public uint GlobalVariables;
    /// <include file='D3D10_EFFECT_DESC.xml' path='doc/member[@name="D3D10_EFFECT_DESC.SharedGlobalVariables"]/*'/>
    public uint SharedGlobalVariables;
    /// <include file='D3D10_EFFECT_DESC.xml' path='doc/member[@name="D3D10_EFFECT_DESC.Techniques"]/*'/>
    public uint Techniques;
}