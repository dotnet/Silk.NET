// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='WINHTTP_EXTENDED_HEADER.xml' path='doc/member[@name="WINHTTP_EXTENDED_HEADER"]/*' />
public unsafe partial struct WINHTTP_EXTENDED_HEADER
{
    /// <include file='WINHTTP_EXTENDED_HEADER.xml' path='doc/member[@name="WINHTTP_EXTENDED_HEADER.Anonymous1"]/*' />
    [NativeTypeName("__AnonymousRecord_winhttp_L514_C5")]
    public _Anonymous1_e__Union Anonymous1;

    /// <include file='WINHTTP_EXTENDED_HEADER.xml' path='doc/member[@name="WINHTTP_EXTENDED_HEADER.Anonymous2"]/*' />
    [NativeTypeName("__AnonymousRecord_winhttp_L519_C5")]
    public _Anonymous2_e__Union Anonymous2;

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pwszName"]/*' />
    [UnscopedRef]
    public ref ushort* pwszName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.pwszName;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszName"]/*' />
    [UnscopedRef]
    public ref sbyte* pszName
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.pszName;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pwszValue"]/*' />
    [UnscopedRef]
    public ref ushort* pwszValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.pwszValue;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pszValue"]/*' />
    [UnscopedRef]
    public ref sbyte* pszValue
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.pszValue;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pwszName"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("PCWSTR")]
        public ushort* pwszName;

        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.pszName"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("PCSTR")]
        public sbyte* pszName;
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pwszValue"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("PCWSTR")]
        public ushort* pwszValue;

        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.pszValue"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("PCSTR")]
        public sbyte* pszValue;
    }
}
