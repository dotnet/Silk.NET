// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA.xml' path='doc/member[@name="IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA"]/*'/>
[StructLayout(LayoutKind.Explicit)]
public partial struct IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA
{
    /// <include file='IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA.xml' path='doc/member[@name="IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA.HeaderData"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("DWORD")]
    public uint HeaderData;
    /// <include file='IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA.xml' path='doc/member[@name="IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY_XDATA.Anonymous"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L20229_C5")]
    public _Anonymous_e__Struct Anonymous;
    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.FunctionLength"]/*'/>
    public uint FunctionLength
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.FunctionLength;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.FunctionLength = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Version"]/*'/>
    public uint Version
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.Version;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.Version = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ExceptionDataPresent"]/*'/>
    public uint ExceptionDataPresent
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.ExceptionDataPresent;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.ExceptionDataPresent = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EpilogInHeader"]/*'/>
    public uint EpilogInHeader
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.EpilogInHeader;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.EpilogInHeader = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EpilogCount"]/*'/>
    public uint EpilogCount
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.EpilogCount;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.EpilogCount = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.CodeWords"]/*'/>
    public uint CodeWords
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous.CodeWords;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous.CodeWords = value;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
    public partial struct _Anonymous_e__Struct
    {
        public uint _bitfield;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.FunctionLength"]/*'/>
        [NativeTypeName("DWORD : 18")]
        public uint FunctionLength
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0x3FFFFu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0x3FFFFu) | (value & 0x3FFFFu);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.Version"]/*'/>
        [NativeTypeName("DWORD : 2")]
        public uint Version
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 18) & 0x3u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x3u << 18)) | ((value & 0x3u) << 18);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.ExceptionDataPresent"]/*'/>
        [NativeTypeName("DWORD : 1")]
        public uint ExceptionDataPresent
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 20) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 20)) | ((value & 0x1u) << 20);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EpilogInHeader"]/*'/>
        [NativeTypeName("DWORD : 1")]
        public uint EpilogInHeader
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 21) & 0x1u;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1u << 21)) | ((value & 0x1u) << 21);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.EpilogCount"]/*'/>
        [NativeTypeName("DWORD : 5")]
        public uint EpilogCount
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 22) & 0x1Fu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1Fu << 22)) | ((value & 0x1Fu) << 22);
            }
        }

        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.CodeWords"]/*'/>
        [NativeTypeName("DWORD : 5")]
        public uint CodeWords
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 27) & 0x1Fu;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0x1Fu << 27)) | ((value & 0x1Fu) << 27);
            }
        }
    }
}