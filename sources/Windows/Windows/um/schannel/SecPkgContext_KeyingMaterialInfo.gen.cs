// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='SecPkgContext_KeyingMaterialInfo.xml' path='doc/member[@name="SecPkgContext_KeyingMaterialInfo"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct SecPkgContext_KeyingMaterialInfo
{
    /// <include file='SecPkgContext_KeyingMaterialInfo.xml' path='doc/member[@name="SecPkgContext_KeyingMaterialInfo.cbLabel"]/*'/>
    [NativeTypeName("WORD")]
    public ushort cbLabel;
    /// <include file='SecPkgContext_KeyingMaterialInfo.xml' path='doc/member[@name="SecPkgContext_KeyingMaterialInfo.pszLabel"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszLabel;
    /// <include file='SecPkgContext_KeyingMaterialInfo.xml' path='doc/member[@name="SecPkgContext_KeyingMaterialInfo.cbContextValue"]/*'/>
    [NativeTypeName("WORD")]
    public ushort cbContextValue;
    /// <include file='SecPkgContext_KeyingMaterialInfo.xml' path='doc/member[@name="SecPkgContext_KeyingMaterialInfo.pbContextValue"]/*'/>
    [NativeTypeName("PBYTE")]
    public byte* pbContextValue;
    /// <include file='SecPkgContext_KeyingMaterialInfo.xml' path='doc/member[@name="SecPkgContext_KeyingMaterialInfo.cbKeyingMaterial"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbKeyingMaterial;
}