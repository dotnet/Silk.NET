// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='CERT_STRONG_SIGN_PARA.xml' path='doc/member[@name="CERT_STRONG_SIGN_PARA"]/*'/>
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct CERT_STRONG_SIGN_PARA
{
    /// <include file='CERT_STRONG_SIGN_PARA.xml' path='doc/member[@name="CERT_STRONG_SIGN_PARA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CERT_STRONG_SIGN_PARA.xml' path='doc/member[@name="CERT_STRONG_SIGN_PARA.dwInfoChoice"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwInfoChoice;
    /// <include file='CERT_STRONG_SIGN_PARA.xml' path='doc/member[@name="CERT_STRONG_SIGN_PARA.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_wincrypt_L6544_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pvInfo"]/*'/>
    [UnscopedRef]
    public ref void* pvInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pvInfo;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSerializedInfo"]/*'/>
    [UnscopedRef]
    public ref CERT_STRONG_SIGN_SERIALIZED_INFO* pSerializedInfo
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pSerializedInfo;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pszOID"]/*'/>
    [UnscopedRef]
    public ref sbyte* pszOID
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.pszOID;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pvInfo"]/*'/>
        [FieldOffset(0)]
        public void* pvInfo;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pSerializedInfo"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PCERT_STRONG_SIGN_SERIALIZED_INFO")]
        public CERT_STRONG_SIGN_SERIALIZED_INFO* pSerializedInfo;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.pszOID"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("LPSTR")]
        public sbyte* pszOID;
    }
}