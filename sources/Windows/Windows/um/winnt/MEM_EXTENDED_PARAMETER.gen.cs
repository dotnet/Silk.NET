// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='MEM_EXTENDED_PARAMETER.xml' path='doc/member[@name="MEM_EXTENDED_PARAMETER"]/*'/>
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct MEM_EXTENDED_PARAMETER
{
    /// <include file='MEM_EXTENDED_PARAMETER.xml' path='doc/member[@name="MEM_EXTENDED_PARAMETER.Anonymous1"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L14113_C5")]
    public _Anonymous1_e__Struct Anonymous1;
    /// <include file='MEM_EXTENDED_PARAMETER.xml' path='doc/member[@name="MEM_EXTENDED_PARAMETER.Anonymous2"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L14118_C5")]
    public _Anonymous2_e__Union Anonymous2;
    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.Type"]/*'/>
    public ulong Type
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous1.Type;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous1.Type = value;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.Reserved"]/*'/>
    public ulong Reserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return Anonymous1.Reserved;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        set
        {
            Anonymous1.Reserved = value;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.ULong64"]/*'/>
    [UnscopedRef]
    public ref ulong ULong64
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.ULong64;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Pointer"]/*'/>
    [UnscopedRef]
    public ref void* Pointer
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.Pointer;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Size"]/*'/>
    [UnscopedRef]
    public ref nuint Size
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.Size;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Handle"]/*'/>
    [UnscopedRef]
    public ref HANDLE Handle
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.Handle;
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.ULong"]/*'/>
    [UnscopedRef]
    public ref uint ULong
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous2.ULong;
        }
    }

    /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct"]/*'/>
    public partial struct _Anonymous1_e__Struct
    {
        public ulong _bitfield;
        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.Type"]/*'/>
        [NativeTypeName("DWORD64 : 8")]
        public ulong Type
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return _bitfield & 0xFFUL;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~0xFFUL) | (value & 0xFFUL);
            }
        }

        /// <include file='_Anonymous1_e__Struct.xml' path='doc/member[@name="_Anonymous1_e__Struct.Reserved"]/*'/>
        [NativeTypeName("DWORD64 : 56")]
        public ulong Reserved
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return (_bitfield >> 8) & 0xFFFFFFUL;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set
            {
                _bitfield = (_bitfield & ~(0xFFFFFFUL << 8)) | ((value & 0xFFFFFFUL) << 8);
            }
        }
    }

    /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Anonymous2_e__Union
    {
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.ULong64"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD64")]
        public ulong ULong64;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Pointer"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PVOID")]
        public void* Pointer;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Size"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("SIZE_T")]
        public nuint Size;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.Handle"]/*'/>
        [FieldOffset(0)]
        public HANDLE Handle;
        /// <include file='_Anonymous2_e__Union.xml' path='doc/member[@name="_Anonymous2_e__Union.ULong"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint ULong;
    }
}