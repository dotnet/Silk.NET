// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SCH_CRED_PUBLIC_CERTCHAIN.xml' path='doc/member[@name="SCH_CRED_PUBLIC_CERTCHAIN"]/*'/>
public unsafe partial struct SCH_CRED_PUBLIC_CERTCHAIN
{
    /// <include file='SCH_CRED_PUBLIC_CERTCHAIN.xml' path='doc/member[@name="SCH_CRED_PUBLIC_CERTCHAIN.dwType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwType;
    /// <include file='SCH_CRED_PUBLIC_CERTCHAIN.xml' path='doc/member[@name="SCH_CRED_PUBLIC_CERTCHAIN.cbCertChain"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbCertChain;
    /// <include file='SCH_CRED_PUBLIC_CERTCHAIN.xml' path='doc/member[@name="SCH_CRED_PUBLIC_CERTCHAIN.pCertChain"]/*'/>
    [NativeTypeName("PBYTE")]
    public byte* pCertChain;
}