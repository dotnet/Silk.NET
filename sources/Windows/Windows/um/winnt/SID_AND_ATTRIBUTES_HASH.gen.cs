// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='SID_AND_ATTRIBUTES_HASH.xml' path='doc/member[@name="SID_AND_ATTRIBUTES_HASH"]/*' />
public unsafe partial struct SID_AND_ATTRIBUTES_HASH
{
    /// <include file='SID_AND_ATTRIBUTES_HASH.xml' path='doc/member[@name="SID_AND_ATTRIBUTES_HASH.SidCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint SidCount;

    /// <include file='SID_AND_ATTRIBUTES_HASH.xml' path='doc/member[@name="SID_AND_ATTRIBUTES_HASH.SidAttr"]/*' />
    [NativeTypeName("PSID_AND_ATTRIBUTES")]
    public SID_AND_ATTRIBUTES* SidAttr;

    /// <include file='SID_AND_ATTRIBUTES_HASH.xml' path='doc/member[@name="SID_AND_ATTRIBUTES_HASH.Hash"]/*' />
    [NativeTypeName("SID_HASH_ENTRY[32]")]
    public _Hash_e__FixedBuffer Hash;

    /// <include file='_Hash_e__FixedBuffer.xml' path='doc/member[@name="_Hash_e__FixedBuffer"]/*' />
    public partial struct _Hash_e__FixedBuffer
    {
        public nuint e0;
        public nuint e1;
        public nuint e2;
        public nuint e3;
        public nuint e4;
        public nuint e5;
        public nuint e6;
        public nuint e7;
        public nuint e8;
        public nuint e9;
        public nuint e10;
        public nuint e11;
        public nuint e12;
        public nuint e13;
        public nuint e14;
        public nuint e15;
        public nuint e16;
        public nuint e17;
        public nuint e18;
        public nuint e19;
        public nuint e20;
        public nuint e21;
        public nuint e22;
        public nuint e23;
        public nuint e24;
        public nuint e25;
        public nuint e26;
        public nuint e27;
        public nuint e28;
        public nuint e29;
        public nuint e30;
        public nuint e31;

        [UnscopedRef]
        public ref nuint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<nuint> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 32);
    }
}
