// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX"]/*'/>
[StructLayout(LayoutKind.Explicit)]
public unsafe partial struct IMAGE_AUX_SYMBOL_EX
{
    /// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX.Sym"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L18956_C5")]
    public _Sym_e__Struct Sym;
    /// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX.File"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L18961_C5")]
    public _File_e__Struct File;
    /// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX.Section"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L18964_C5")]
    public _Section_e__Struct Section;
    /// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX.Anonymous"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L18975_C5")]
    public _Anonymous_e__Struct Anonymous;
    /// <include file='IMAGE_AUX_SYMBOL_EX.xml' path='doc/member[@name="IMAGE_AUX_SYMBOL_EX.CRC"]/*'/>
    [FieldOffset(0)]
    [NativeTypeName("__AnonymousRecord_winnt_L18979_C5")]
    public _CRC_e__Struct CRC;
    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.TokenDef"]/*'/>
    [UnscopedRef]
    public ref IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.TokenDef;
        }
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.rgbReserved"]/*'/>
    [UnscopedRef]
    public Span<byte> rgbReserved
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return MemoryMarshal.CreateSpan(ref Anonymous.rgbReserved[0], 2);
        }
    }

    /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct"]/*'/>
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe partial struct _Sym_e__Struct
    {
        /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct.WeakDefaultSymIndex"]/*'/>
        [NativeTypeName("DWORD")]
        public uint WeakDefaultSymIndex;
        /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct.WeakSearchType"]/*'/>
        [NativeTypeName("DWORD")]
        public uint WeakSearchType;
        /// <include file='_Sym_e__Struct.xml' path='doc/member[@name="_Sym_e__Struct.rgbReserved"]/*'/>
        [NativeTypeName("BYTE[12]")]
        public fixed byte rgbReserved[12];
    }

    /// <include file='_File_e__Struct.xml' path='doc/member[@name="_File_e__Struct"]/*'/>
    public unsafe partial struct _File_e__Struct
    {
        /// <include file='_File_e__Struct.xml' path='doc/member[@name="_File_e__Struct.Name"]/*'/>
        [NativeTypeName("BYTE[20]")]
        public fixed byte Name[20];
    }

    /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct"]/*'/>
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe partial struct _Section_e__Struct
    {
        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.Length"]/*'/>
        [NativeTypeName("DWORD")]
        public uint Length;
        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.NumberOfRelocations"]/*'/>
        [NativeTypeName("WORD")]
        public ushort NumberOfRelocations;
        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.NumberOfLinenumbers"]/*'/>
        [NativeTypeName("WORD")]
        public ushort NumberOfLinenumbers;
        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.CheckSum"]/*'/>
        [NativeTypeName("DWORD")]
        public uint CheckSum;
        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.Number"]/*'/>
        public short Number;
        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.Selection"]/*'/>
        public byte Selection;
        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.bReserved"]/*'/>
        public byte bReserved;
        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.HighNumber"]/*'/>
        public short HighNumber;
        /// <include file='_Section_e__Struct.xml' path='doc/member[@name="_Section_e__Struct.rgbReserved"]/*'/>
        [NativeTypeName("BYTE[2]")]
        public fixed byte rgbReserved[2];
    }

    /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct"]/*'/>
    public unsafe partial struct _Anonymous_e__Struct
    {
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.TokenDef"]/*'/>
        public IMAGE_AUX_SYMBOL_TOKEN_DEF TokenDef;
        /// <include file='_Anonymous_e__Struct.xml' path='doc/member[@name="_Anonymous_e__Struct.rgbReserved"]/*'/>
        [NativeTypeName("BYTE[2]")]
        public fixed byte rgbReserved[2];
    }

    /// <include file='_CRC_e__Struct.xml' path='doc/member[@name="_CRC_e__Struct"]/*'/>
    [StructLayout(LayoutKind.Sequential, Pack = 2)]
    public unsafe partial struct _CRC_e__Struct
    {
        /// <include file='_CRC_e__Struct.xml' path='doc/member[@name="_CRC_e__Struct.crc"]/*'/>
        [NativeTypeName("DWORD")]
        public uint crc;
        /// <include file='_CRC_e__Struct.xml' path='doc/member[@name="_CRC_e__Struct.rgbReserved"]/*'/>
        [NativeTypeName("BYTE[16]")]
        public fixed byte rgbReserved[16];
    }
}