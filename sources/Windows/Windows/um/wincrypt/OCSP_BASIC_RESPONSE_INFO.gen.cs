// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='OCSP_BASIC_RESPONSE_INFO.xml' path='doc/member[@name="OCSP_BASIC_RESPONSE_INFO"]/*' />
public unsafe partial struct OCSP_BASIC_RESPONSE_INFO
{
    /// <include file='OCSP_BASIC_RESPONSE_INFO.xml' path='doc/member[@name="OCSP_BASIC_RESPONSE_INFO.dwVersion"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwVersion;

    /// <include file='OCSP_BASIC_RESPONSE_INFO.xml' path='doc/member[@name="OCSP_BASIC_RESPONSE_INFO.dwResponderIdChoice"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwResponderIdChoice;

    /// <include file='OCSP_BASIC_RESPONSE_INFO.xml' path='doc/member[@name="OCSP_BASIC_RESPONSE_INFO.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_wincrypt_L5717_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='OCSP_BASIC_RESPONSE_INFO.xml' path='doc/member[@name="OCSP_BASIC_RESPONSE_INFO.ProducedAt"]/*' />
    public FILETIME ProducedAt;

    /// <include file='OCSP_BASIC_RESPONSE_INFO.xml' path='doc/member[@name="OCSP_BASIC_RESPONSE_INFO.cResponseEntry"]/*' />
    [NativeTypeName("DWORD")]
    public uint cResponseEntry;

    /// <include file='OCSP_BASIC_RESPONSE_INFO.xml' path='doc/member[@name="OCSP_BASIC_RESPONSE_INFO.rgResponseEntry"]/*' />
    [NativeTypeName("POCSP_BASIC_RESPONSE_ENTRY")]
    public OCSP_BASIC_RESPONSE_ENTRY* rgResponseEntry;

    /// <include file='OCSP_BASIC_RESPONSE_INFO.xml' path='doc/member[@name="OCSP_BASIC_RESPONSE_INFO.cExtension"]/*' />
    [NativeTypeName("DWORD")]
    public uint cExtension;

    /// <include file='OCSP_BASIC_RESPONSE_INFO.xml' path='doc/member[@name="OCSP_BASIC_RESPONSE_INFO.rgExtension"]/*' />
    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ByNameResponderId"]/*' />
    [UnscopedRef]
    public ref CRYPT_DATA_BLOB ByNameResponderId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ByNameResponderId;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ByKeyResponderId"]/*' />
    [UnscopedRef]
    public ref CRYPT_DATA_BLOB ByKeyResponderId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ByKeyResponderId;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ByNameResponderId"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("CERT_NAME_BLOB")]
        public CRYPT_DATA_BLOB ByNameResponderId;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ByKeyResponderId"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("CRYPT_HASH_BLOB")]
        public CRYPT_DATA_BLOB ByKeyResponderId;
    }
}
