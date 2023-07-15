// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='SCHANNEL_CRED.xml' path='doc/member[@name="SCHANNEL_CRED"]/*'/>
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct SCHANNEL_CRED
{
    /// <include file='SCHANNEL_CRED.xml' path='doc/member[@name="SCHANNEL_CRED.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='SCHANNEL_CRED.xml' path='doc/member[@name="SCHANNEL_CRED.cCreds"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cCreds;
    /// <include file='SCHANNEL_CRED.xml' path='doc/member[@name="SCHANNEL_CRED.paCred"]/*'/>
    [NativeTypeName("PCCERT_CONTEXT *")]
    public CERT_CONTEXT** paCred;
    /// <include file='SCHANNEL_CRED.xml' path='doc/member[@name="SCHANNEL_CRED.hRootStore"]/*'/>
    public HCERTSTORE hRootStore;
    /// <include file='SCHANNEL_CRED.xml' path='doc/member[@name="SCHANNEL_CRED.cMappers"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cMappers;
    /// <include file='SCHANNEL_CRED.xml' path='doc/member[@name="SCHANNEL_CRED.aphMappers"]/*'/>
    [NativeTypeName("struct _HMAPPER **")]
    public IntPtr* aphMappers;
    /// <include file='SCHANNEL_CRED.xml' path='doc/member[@name="SCHANNEL_CRED.cSupportedAlgs"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cSupportedAlgs;
    /// <include file='SCHANNEL_CRED.xml' path='doc/member[@name="SCHANNEL_CRED.palgSupportedAlgs"]/*'/>
    [NativeTypeName("ALG_ID *")]
    public uint* palgSupportedAlgs;
    /// <include file='SCHANNEL_CRED.xml' path='doc/member[@name="SCHANNEL_CRED.grbitEnabledProtocols"]/*'/>
    [NativeTypeName("DWORD")]
    public uint grbitEnabledProtocols;
    /// <include file='SCHANNEL_CRED.xml' path='doc/member[@name="SCHANNEL_CRED.dwMinimumCipherStrength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMinimumCipherStrength;
    /// <include file='SCHANNEL_CRED.xml' path='doc/member[@name="SCHANNEL_CRED.dwMaximumCipherStrength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwMaximumCipherStrength;
    /// <include file='SCHANNEL_CRED.xml' path='doc/member[@name="SCHANNEL_CRED.dwSessionLifespan"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSessionLifespan;
    /// <include file='SCHANNEL_CRED.xml' path='doc/member[@name="SCHANNEL_CRED.dwFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwFlags;
    /// <include file='SCHANNEL_CRED.xml' path='doc/member[@name="SCHANNEL_CRED.dwCredFormat"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCredFormat;
}