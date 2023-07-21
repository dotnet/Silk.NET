// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='CERT_BIOMETRIC_DATA.xml' path='doc/member[@name="CERT_BIOMETRIC_DATA"]/*' />
public unsafe partial struct CERT_BIOMETRIC_DATA
{
    /// <include file='CERT_BIOMETRIC_DATA.xml' path='doc/member[@name="CERT_BIOMETRIC_DATA.dwTypeOfBiometricDataChoice"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwTypeOfBiometricDataChoice;

    /// <include file='CERT_BIOMETRIC_DATA.xml' path='doc/member[@name="CERT_BIOMETRIC_DATA.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_wincrypt_L5564_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='CERT_BIOMETRIC_DATA.xml' path='doc/member[@name="CERT_BIOMETRIC_DATA.HashedUrl"]/*' />
    public CERT_HASHED_URL HashedUrl;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwPredefined"]/*' />
    [UnscopedRef]
    public ref uint dwPredefined
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwPredefined;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pszObjId"]/*' />
    [UnscopedRef]
    public ref sbyte* pszObjId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pszObjId;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwPredefined"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwPredefined;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pszObjId"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPSTR")]
        public sbyte* pszObjId;
    }
}
