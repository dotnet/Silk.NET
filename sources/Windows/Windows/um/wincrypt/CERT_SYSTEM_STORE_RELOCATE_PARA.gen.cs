// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='CERT_SYSTEM_STORE_RELOCATE_PARA.xml' path='doc/member[@name="CERT_SYSTEM_STORE_RELOCATE_PARA"]/*' />
public unsafe partial struct CERT_SYSTEM_STORE_RELOCATE_PARA
{
    /// <include file='CERT_SYSTEM_STORE_RELOCATE_PARA.xml' path='doc/member[@name="CERT_SYSTEM_STORE_RELOCATE_PARA.Anonymous1"]/*' />
    [NativeTypeName("__AnonymousRecord_wincrypt_L9498_C5")]
    public _Anonymous1_e__Union Anonymous1;

    /// <include file='CERT_SYSTEM_STORE_RELOCATE_PARA.xml' path='doc/member[@name="CERT_SYSTEM_STORE_RELOCATE_PARA.Anonymous2"]/*' />
    [NativeTypeName("__AnonymousRecord_wincrypt_L9502_C5")]
    public _Anonymous2_e__Union Anonymous2;

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.hKeyBase"]/*' />
    [UnscopedRef]
    public ref HKEY hKeyBase
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.hKeyBase;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pvBase"]/*' />
    [UnscopedRef]
    public ref void* pvBase
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.pvBase;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pvSystemStore"]/*' />
    [UnscopedRef]
    public ref void* pvSystemStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.pvSystemStore;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pszSystemStore"]/*' />
    [UnscopedRef]
    public ref sbyte* pszSystemStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.pszSystemStore;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pwszSystemStore"]/*' />
    [UnscopedRef]
    public ref ushort* pwszSystemStore
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.pwszSystemStore;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.hKeyBase"]/*' />
        [FieldOffset(0)]
        public HKEY hKeyBase;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pvBase"]/*' />
        [FieldOffset(0)]
        public void* pvBase;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pvSystemStore"]/*' />
        [FieldOffset(0)]
        public void* pvSystemStore;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pszSystemStore"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCSTR")]
        public sbyte* pszSystemStore;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pwszSystemStore"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("LPCWSTR")]
        public ushort* pwszSystemStore;
    }
}
