// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='CRYPT_PROVIDER_SIGSTATE.xml' path='doc/member[@name="CRYPT_PROVIDER_SIGSTATE"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct CRYPT_PROVIDER_SIGSTATE
{
    /// <include file='CRYPT_PROVIDER_SIGSTATE.xml' path='doc/member[@name="CRYPT_PROVIDER_SIGSTATE.cbStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    /// <include file='CRYPT_PROVIDER_SIGSTATE.xml' path='doc/member[@name="CRYPT_PROVIDER_SIGSTATE.rhSecondarySigs"]/*'/>
    public HCRYPTMSG* rhSecondarySigs;
    /// <include file='CRYPT_PROVIDER_SIGSTATE.xml' path='doc/member[@name="CRYPT_PROVIDER_SIGSTATE.hPrimarySig"]/*'/>
    public HCRYPTMSG hPrimarySig;
    /// <include file='CRYPT_PROVIDER_SIGSTATE.xml' path='doc/member[@name="CRYPT_PROVIDER_SIGSTATE.fFirstAttemptMade"]/*'/>
    public BOOL fFirstAttemptMade;
    /// <include file='CRYPT_PROVIDER_SIGSTATE.xml' path='doc/member[@name="CRYPT_PROVIDER_SIGSTATE.fNoMoreSigs"]/*'/>
    public BOOL fNoMoreSigs;
    /// <include file='CRYPT_PROVIDER_SIGSTATE.xml' path='doc/member[@name="CRYPT_PROVIDER_SIGSTATE.cSecondarySigs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cSecondarySigs;
    /// <include file='CRYPT_PROVIDER_SIGSTATE.xml' path='doc/member[@name="CRYPT_PROVIDER_SIGSTATE.dwCurrentIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCurrentIndex;
    /// <include file='CRYPT_PROVIDER_SIGSTATE.xml' path='doc/member[@name="CRYPT_PROVIDER_SIGSTATE.fSupportMultiSig"]/*'/>
    public BOOL fSupportMultiSig;
    /// <include file='CRYPT_PROVIDER_SIGSTATE.xml' path='doc/member[@name="CRYPT_PROVIDER_SIGSTATE.dwCryptoPolicySupport"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCryptoPolicySupport;
    /// <include file='CRYPT_PROVIDER_SIGSTATE.xml' path='doc/member[@name="CRYPT_PROVIDER_SIGSTATE.iAttemptCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iAttemptCount;
    /// <include file='CRYPT_PROVIDER_SIGSTATE.xml' path='doc/member[@name="CRYPT_PROVIDER_SIGSTATE.fCheckedSealing"]/*'/>
    public BOOL fCheckedSealing;
    /// <include file='CRYPT_PROVIDER_SIGSTATE.xml' path='doc/member[@name="CRYPT_PROVIDER_SIGSTATE.pSealingSignature"]/*'/>
    [NativeTypeName("struct _SEALING_SIGNATURE_ATTRIBUTE *")]
    public SEALING_SIGNATURE_ATTRIBUTE* pSealingSignature;
}