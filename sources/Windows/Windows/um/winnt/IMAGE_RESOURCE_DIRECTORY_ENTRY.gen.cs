// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_RESOURCE_DIRECTORY_ENTRY.xml' path='doc/member[@name="IMAGE_RESOURCE_DIRECTORY_ENTRY"]/*'/>
public partial struct IMAGE_RESOURCE_DIRECTORY_ENTRY
{
    /// <include file='IMAGE_RESOURCE_DIRECTORY_ENTRY.xml' path='doc/member[@name="IMAGE_RESOURCE_DIRECTORY_ENTRY.Anonymous1"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L19739_C5")]
    public _Anonymous1_e__Union Anonymous1;
    /// <include file='IMAGE_RESOURCE_DIRECTORY_ENTRY.xml' path='doc/member[@name="IMAGE_RESOURCE_DIRECTORY_ENTRY.Anonymous2"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L19747_C5")]
    public _Anonymous2_e__Union Anonymous2;
    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.NameOffset"]/*'/>
    public uint NameOffset
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous1.Anonymous.NameOffset;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous1.Anonymous.NameOffset = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.NameIsString"]/*'/>
    public uint NameIsString
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous1.Anonymous.NameIsString;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous1.Anonymous.NameIsString = value;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Name"]/*'/>
    [UnscopedRef]
    public ref uint Name
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Name;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Id"]/*'/>
    [UnscopedRef]
    public ref ushort Id
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous1.Id;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.OffsetToData"]/*'/>
    [UnscopedRef]
    public ref uint OffsetToData
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.OffsetToData;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.OffsetToDirectory"]/*'/>
    public uint OffsetToDirectory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous2.Anonymous.OffsetToDirectory;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous2.Anonymous.OffsetToDirectory = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DataIsDirectory"]/*'/>
    public uint DataIsDirectory
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous2.Anonymous.DataIsDirectory;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous2.Anonymous.DataIsDirectory = value;
        }
    }

    /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous1_e__Union
    {
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Anonymous"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L19740_C9")]
        public _Anonymous_e__Struct Anonymous;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Name"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Name;
        /// <include file='_Anonymous1_e__Union.xml' path='doc/member[@name="_Anonymous1_e__Union.Id"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("WORD")]
        public ushort Id;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.NameOffset"]/*'/>
            [NativeTypeName("DWORD : 31")]
            public uint NameOffset
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield & 0x7FFFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0x7FFFFFFFu) | (value & 0x7FFFFFFFu);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.NameIsString"]/*'/>
            [NativeTypeName("DWORD : 1")]
            public uint NameIsString
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 31) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 31)) | ((value & 0x1u) << 31);
                }
            }
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.OffsetToData"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint OffsetToData;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Anonymous"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L19749_C9")]
        public _Anonymous_e__Struct Anonymous;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.OffsetToDirectory"]/*'/>
            [NativeTypeName("DWORD : 31")]
            public uint OffsetToDirectory
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield & 0x7FFFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0x7FFFFFFFu) | (value & 0x7FFFFFFFu);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.DataIsDirectory"]/*'/>
            [NativeTypeName("DWORD : 1")]
            public uint DataIsDirectory
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 31) & 0x1u;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0x1u << 31)) | ((value & 0x1u) << 31);
                }
            }
        }
    }
}