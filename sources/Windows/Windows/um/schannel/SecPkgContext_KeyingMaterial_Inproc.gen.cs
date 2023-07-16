// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SecPkgContext_KeyingMaterial_Inproc.xml' path='doc/member[@name="SecPkgContext_KeyingMaterial_Inproc"]/*'/>
public unsafe partial struct SecPkgContext_KeyingMaterial_Inproc
{
    /// <include file='SecPkgContext_KeyingMaterial_Inproc.xml' path='doc/member[@name="SecPkgContext_KeyingMaterial_Inproc.cbLabel"]/*'/>
    [NativeTypeName("WORD")]
    public ushort cbLabel;
    /// <include file='SecPkgContext_KeyingMaterial_Inproc.xml' path='doc/member[@name="SecPkgContext_KeyingMaterial_Inproc.pszLabel"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* pszLabel;
    /// <include file='SecPkgContext_KeyingMaterial_Inproc.xml' path='doc/member[@name="SecPkgContext_KeyingMaterial_Inproc.cbContextValue"]/*'/>
    [NativeTypeName("WORD")]
    public ushort cbContextValue;
    /// <include file='SecPkgContext_KeyingMaterial_Inproc.xml' path='doc/member[@name="SecPkgContext_KeyingMaterial_Inproc.pbContextValue"]/*'/>
    [NativeTypeName("PBYTE")]
    public byte* pbContextValue;
    /// <include file='SecPkgContext_KeyingMaterial_Inproc.xml' path='doc/member[@name="SecPkgContext_KeyingMaterial_Inproc.cbKeyingMaterial"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbKeyingMaterial;
    /// <include file='SecPkgContext_KeyingMaterial_Inproc.xml' path='doc/member[@name="SecPkgContext_KeyingMaterial_Inproc.pbKeyingMaterial"]/*'/>
    [NativeTypeName("PBYTE")]
    public byte* pbKeyingMaterial;
}