// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='WINTRUST_SIGNATURE_SETTINGS.xml' path='doc/member[@name="WINTRUST_SIGNATURE_SETTINGS"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct WINTRUST_SIGNATURE_SETTINGS
{
    /// <include file='WINTRUST_SIGNATURE_SETTINGS.xml' path='doc/member[@name="WINTRUST_SIGNATURE_SETTINGS.cbStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbStruct;
    /// <include file='WINTRUST_SIGNATURE_SETTINGS.xml' path='doc/member[@name="WINTRUST_SIGNATURE_SETTINGS.dwIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwIndex;
    /// <include file='WINTRUST_SIGNATURE_SETTINGS.xml' path='doc/member[@name="WINTRUST_SIGNATURE_SETTINGS.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='WINTRUST_SIGNATURE_SETTINGS.xml' path='doc/member[@name="WINTRUST_SIGNATURE_SETTINGS.cSecondarySigs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cSecondarySigs;
    /// <include file='WINTRUST_SIGNATURE_SETTINGS.xml' path='doc/member[@name="WINTRUST_SIGNATURE_SETTINGS.dwVerifiedSigIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVerifiedSigIndex;
    /// <include file='WINTRUST_SIGNATURE_SETTINGS.xml' path='doc/member[@name="WINTRUST_SIGNATURE_SETTINGS.pCryptoPolicy"]/*'/>
    [NativeTypeName("PCERT_STRONG_SIGN_PARA")]
    public CERT_STRONG_SIGN_PARA* pCryptoPolicy;
}