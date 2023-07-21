// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

/// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER"]/*' />
public partial struct IMPORT_OBJECT_HEADER
{
    /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.Sig1"]/*' />
    [NativeTypeName("WORD")]
    public ushort Sig1;

    /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.Sig2"]/*' />
    [NativeTypeName("WORD")]
    public ushort Sig2;

    /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.Version"]/*' />
    [NativeTypeName("WORD")]
    public ushort Version;

    /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.Machine"]/*' />
    [NativeTypeName("WORD")]
    public ushort Machine;

    /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.TimeDateStamp"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.SizeOfData"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfData;

    /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winnt_L20581_C5")]
    public _Anonymous_e__Union Anonymous;

    public ushort _bitfield;

    /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.Type"]/*' />
    [NativeTypeName("WORD : 2")]
    public ushort Type
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)(_bitfield & 0x3u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~0x3u) | (value & 0x3u));
        }
    }

    /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.NameType"]/*' />
    [NativeTypeName("WORD : 3")]
    public ushort NameType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)((_bitfield >> 2) & 0x7u);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~(0x7u << 2)) | ((value & 0x7u) << 2));
        }
    }

    /// <include file='IMPORT_OBJECT_HEADER.xml' path='doc/member[@name="IMPORT_OBJECT_HEADER.Reserved"]/*' />
    [NativeTypeName("WORD : 11")]
    public ushort Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return (ushort)((_bitfield >> 5) & 0x7FFu);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            _bitfield = (ushort)((_bitfield & ~(0x7FFu << 5)) | ((value & 0x7FFu) << 5));
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Ordinal"]/*' />
    [UnscopedRef]
    public ref ushort Ordinal
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Ordinal;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Hint"]/*' />
    [UnscopedRef]
    public ref ushort Hint
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Hint;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Ordinal"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort Ordinal;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Hint"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort Hint;
    }
}
