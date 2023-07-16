// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='OCSP_BASIC_RESPONSE_ENTRY.xml' path='doc/member[@name="OCSP_BASIC_RESPONSE_ENTRY"]/*'/>
public unsafe partial struct OCSP_BASIC_RESPONSE_ENTRY
{
    /// <include file='OCSP_BASIC_RESPONSE_ENTRY.xml' path='doc/member[@name="OCSP_BASIC_RESPONSE_ENTRY.CertId"]/*'/>
    public OCSP_CERT_ID CertId;
    /// <include file='OCSP_BASIC_RESPONSE_ENTRY.xml' path='doc/member[@name="OCSP_BASIC_RESPONSE_ENTRY.dwCertStatus"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCertStatus;
    /// <include file='OCSP_BASIC_RESPONSE_ENTRY.xml' path='doc/member[@name="OCSP_BASIC_RESPONSE_ENTRY.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wincrypt_L5693_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='OCSP_BASIC_RESPONSE_ENTRY.xml' path='doc/member[@name="OCSP_BASIC_RESPONSE_ENTRY.ThisUpdate"]/*'/>
    public FILETIME ThisUpdate;
    /// <include file='OCSP_BASIC_RESPONSE_ENTRY.xml' path='doc/member[@name="OCSP_BASIC_RESPONSE_ENTRY.NextUpdate"]/*'/>
    public FILETIME NextUpdate;
    /// <include file='OCSP_BASIC_RESPONSE_ENTRY.xml' path='doc/member[@name="OCSP_BASIC_RESPONSE_ENTRY.cExtension"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cExtension;
    /// <include file='OCSP_BASIC_RESPONSE_ENTRY.xml' path='doc/member[@name="OCSP_BASIC_RESPONSE_ENTRY.rgExtension"]/*'/>
    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pRevokedInfo"]/*'/>
    [UnscopedRef]
    public ref OCSP_BASIC_REVOKED_INFO* pRevokedInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pRevokedInfo;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pRevokedInfo"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("POCSP_BASIC_REVOKED_INFO")]
        public OCSP_BASIC_REVOKED_INFO* pRevokedInfo;
    }
}