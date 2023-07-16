// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Psapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='PSAPI_WORKING_SET_BLOCK.xml' path='doc/member[@name="PSAPI_WORKING_SET_BLOCK"]/*'/>
[StructLayout(LayoutKind.Explicit)]
public partial struct PSAPI_WORKING_SET_BLOCK
{
    /// <include file='PSAPI_WORKING_SET_BLOCK.xml' path='doc/member[@name="PSAPI_WORKING_SET_BLOCK.Flags"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("ULONG_PTR")]
    public nuint Flags;
    /// <include file='PSAPI_WORKING_SET_BLOCK.xml' path='doc/member[@name="PSAPI_WORKING_SET_BLOCK.Anonymous"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_Psapi_L386_C5")]
    public _Anonymous_e__Struct Anonymous;
    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Protection"]/*'/>
    public nuint Protection
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Protection;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Protection = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ShareCount"]/*'/>
    public nuint ShareCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.ShareCount;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.ShareCount = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Shared"]/*'/>
    public nuint Shared
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Shared;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Shared = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*'/>
    public nuint Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Reserved;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Reserved = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.VirtualPage"]/*'/>
    public nuint VirtualPage
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.VirtualPage;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.VirtualPage = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
    public partial struct _Anonymous_e__Struct
    {
        public nuint _bitfield;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Protection"]/*'/>
        [NativeTypeName("ULONG_PTR : 5")]
        public nuint Protection
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0x1Fu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x1Fu) | (value & 0x1Fu);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ShareCount"]/*'/>
        [NativeTypeName("ULONG_PTR : 3")]
        public nuint ShareCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 5) & 0x7u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x7u << 5)) | ((value & 0x7u) << 5);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Shared"]/*'/>
        [NativeTypeName("ULONG_PTR : 1")]
        public nuint Shared
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 8) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 8)) | ((value & 0x1u) << 8);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved"]/*'/>
        [NativeTypeName("ULONG_PTR : 3")]
        public nuint Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 9) & 0x7u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x7u << 9)) | ((value & 0x7u) << 9);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.VirtualPage"]/*'/>
        [NativeTypeName("ULONG_PTR : 52")]
        public nuint VirtualPage
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 12) & 0xFFFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFFFFFu << 12)) | ((value & 0xFFFFFu) << 12);
            }
        }
    }
}