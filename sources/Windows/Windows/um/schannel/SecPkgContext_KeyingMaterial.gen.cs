// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='SecPkgContext_KeyingMaterial.xml' path='doc/member[@name="SecPkgContext_KeyingMaterial"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct SecPkgContext_KeyingMaterial
{
    /// <include file='SecPkgContext_KeyingMaterial.xml' path='doc/member[@name="SecPkgContext_KeyingMaterial.cbKeyingMaterial"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbKeyingMaterial;
    /// <include file='SecPkgContext_KeyingMaterial.xml' path='doc/member[@name="SecPkgContext_KeyingMaterial.pbKeyingMaterial"]/*'/>
    [NativeTypeName("PBYTE")]
    public byte* pbKeyingMaterial;
}