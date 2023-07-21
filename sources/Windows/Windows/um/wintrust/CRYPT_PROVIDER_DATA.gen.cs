// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA"]/*' />
public unsafe partial struct CRYPT_PROVIDER_DATA
{
    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.cbStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbStruct;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.pWintrustData"]/*' />
    public WINTRUST_DATA* pWintrustData;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.fOpenedFile"]/*' />
    public BOOL fOpenedFile;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.hWndParent"]/*' />
    public HWND hWndParent;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.pgActionID"]/*' />
    public Guid* pgActionID;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.hProv"]/*' />
    public HCRYPTPROV hProv;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.dwError"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwError;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.dwRegSecuritySettings"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRegSecuritySettings;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.dwRegPolicySettings"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRegPolicySettings;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.psPfns"]/*' />
    [NativeTypeName("struct _CRYPT_PROVIDER_FUNCTIONS *")]
    public CRYPT_PROVIDER_FUNCTIONS* psPfns;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.cdwTrustStepErrors"]/*' />
    [NativeTypeName("DWORD")]
    public uint cdwTrustStepErrors;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.padwTrustStepErrors"]/*' />
    [NativeTypeName("DWORD *")]
    public uint* padwTrustStepErrors;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.chStores"]/*' />
    [NativeTypeName("DWORD")]
    public uint chStores;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.pahStores"]/*' />
    public HCERTSTORE* pahStores;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.dwEncoding"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwEncoding;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.hMsg"]/*' />
    public HCRYPTMSG hMsg;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.csSigners"]/*' />
    [NativeTypeName("DWORD")]
    public uint csSigners;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.pasSigners"]/*' />
    [NativeTypeName("struct _CRYPT_PROVIDER_SGNR *")]
    public CRYPT_PROVIDER_SGNR* pasSigners;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.csProvPrivData"]/*' />
    [NativeTypeName("DWORD")]
    public uint csProvPrivData;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.pasProvPrivData"]/*' />
    [NativeTypeName("struct _CRYPT_PROVIDER_PRIVDATA *")]
    public CRYPT_PROVIDER_PRIVDATA* pasProvPrivData;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.dwSubjectChoice"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSubjectChoice;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_WinTrust_L681_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.pszUsageOID"]/*' />
    [NativeTypeName("char *")]
    public sbyte* pszUsageOID;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.fRecallWithState"]/*' />
    public BOOL fRecallWithState;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.sftSystemTime"]/*' />
    public FILETIME sftSystemTime;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.pszCTLSignerUsageOID"]/*' />
    [NativeTypeName("char *")]
    public sbyte* pszCTLSignerUsageOID;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.dwProvFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwProvFlags;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.dwFinalError"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFinalError;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.pRequestUsage"]/*' />
    [NativeTypeName("PCERT_USAGE_MATCH")]
    public CERT_USAGE_MATCH* pRequestUsage;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.dwTrustPubSettings"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTrustPubSettings;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.dwUIStateFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwUIStateFlags;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.pSigState"]/*' />
    [NativeTypeName("struct _CRYPT_PROVIDER_SIGSTATE *")]
    public CRYPT_PROVIDER_SIGSTATE* pSigState;

    /// <include file='CRYPT_PROVIDER_DATA.xml' path='doc/member[@name="CRYPT_PROVIDER_DATA.pSigSettings"]/*' />
    [NativeTypeName("struct WINTRUST_SIGNATURE_SETTINGS_ *")]
    public WINTRUST_SIGNATURE_SETTINGS* pSigSettings;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pPDSip"]/*' />
    [UnscopedRef]
    public ref PROVDATA_SIP* pPDSip
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pPDSip;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pPDSip"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("struct _PROVDATA_SIP *")]
        public PROVDATA_SIP* pPDSip;
    }
}
