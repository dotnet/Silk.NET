// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wcsplugin.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='GamutShellTriangle.xml' path='doc/member[@name="GamutShellTriangle"]/*'/>
public unsafe partial struct GamutShellTriangle
{
    /// <include file='GamutShellTriangle.xml' path='doc/member[@name="GamutShellTriangle.aVertexIndex"]/*'/>
    [NativeTypeName("UINT[3]")]
    public fixed uint aVertexIndex[3];
}