// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_TLS_DIRECTORY32.xml' path='doc/member[@name="IMAGE_TLS_DIRECTORY32"]/*'/>
public partial struct IMAGE_TLS_DIRECTORY32
{
    /// <include file='IMAGE_TLS_DIRECTORY32.xml' path='doc/member[@name="IMAGE_TLS_DIRECTORY32.StartAddressOfRawData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint StartAddressOfRawData;
    /// <include file='IMAGE_TLS_DIRECTORY32.xml' path='doc/member[@name="IMAGE_TLS_DIRECTORY32.EndAddressOfRawData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint EndAddressOfRawData;
    /// <include file='IMAGE_TLS_DIRECTORY32.xml' path='doc/member[@name="IMAGE_TLS_DIRECTORY32.AddressOfIndex"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AddressOfIndex;
    /// <include file='IMAGE_TLS_DIRECTORY32.xml' path='doc/member[@name="IMAGE_TLS_DIRECTORY32.AddressOfCallBacks"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AddressOfCallBacks;
    /// <include file='IMAGE_TLS_DIRECTORY32.xml' path='doc/member[@name="IMAGE_TLS_DIRECTORY32.SizeOfZeroFill"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfZeroFill;
    /// <include file='IMAGE_TLS_DIRECTORY32.xml' path='doc/member[@name="IMAGE_TLS_DIRECTORY32.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L19606_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Characteristics"]/*'/>
    [UnscopedRef]
    public ref uint Characteristics
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Characteristics;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved0"]/*'/>
    public uint Reserved0
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.Reserved0;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.Reserved0 = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Alignment"]/*'/>
    public uint Alignment
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.Alignment;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.Alignment = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved1"]/*'/>
    public uint Reserved1
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Anonymous.Reserved1;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Anonymous.Reserved1 = value;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Characteristics"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Characteristics;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Anonymous"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("__AnonymousRecord_winnt_L19608_C9")]
        public _Anonymous_e__Struct Anonymous;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
        public partial struct _Anonymous_e__Struct
        {
            public uint _bitfield;
            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved0"]/*'/>
            [NativeTypeName("DWORD : 20")]
            public uint Reserved0
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return _bitfield & 0xFFFFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~0xFFFFFu) | (value & 0xFFFFFu);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Alignment"]/*'/>
            [NativeTypeName("DWORD : 4")]
            public uint Alignment
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 20) & 0xFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0xFu << 20)) | ((value & 0xFu) << 20);
                }
            }

            /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Reserved1"]/*'/>
            [NativeTypeName("DWORD : 8")]
            public uint Reserved1
            {
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                get
                {
                    return (_bitfield >> 24) & 0xFFu;
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                set
                {
                    _bitfield = (_bitfield & ~(0xFFu << 24)) | ((value & 0xFFu) << 24);
                }
            }
        }
    }
}