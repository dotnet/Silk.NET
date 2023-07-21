// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='SCOPE_TABLE_AMD64.xml' path='doc/member[@name="SCOPE_TABLE_AMD64"]/*' />
public partial struct SCOPE_TABLE_AMD64
{
    /// <include file='SCOPE_TABLE_AMD64.xml' path='doc/member[@name="SCOPE_TABLE_AMD64.Count"]/*' />
    [NativeTypeName("DWORD")]
    public uint Count;

    /// <include file='SCOPE_TABLE_AMD64.xml' path='doc/member[@name="SCOPE_TABLE_AMD64.ScopeRecord"]/*' />
    [NativeTypeName("struct (anonymous struct at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22621.0/um/winnt.h:2740:5)[1]")]
    public _ScopeRecord_e__FixedBuffer ScopeRecord;

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*' />
    public partial struct _Anonymous_e__Struct
    {
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.BeginAddress"]/*' />
        [NativeTypeName("DWORD")]
        public uint BeginAddress;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EndAddress"]/*' />
        [NativeTypeName("DWORD")]
        public uint EndAddress;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.HandlerAddress"]/*' />
        [NativeTypeName("DWORD")]
        public uint HandlerAddress;

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.JumpTarget"]/*' />
        [NativeTypeName("DWORD")]
        public uint JumpTarget;
    }

    /// <include file='_ScopeRecord_e__FixedBuffer.xml' path='doc/member[@name="_ScopeRecord_e__FixedBuffer"]/*' />
    public partial struct _ScopeRecord_e__FixedBuffer
    {
        public _Anonymous_e__Struct e0;

        [UnscopedRef]
        public ref _Anonymous_e__Struct this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<_Anonymous_e__Struct> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
