// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 4)]
public partial struct IMAGE_OPTIONAL_HEADER64
{
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.Magic"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Magic;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.MajorLinkerVersion"]/*'/>
    public byte MajorLinkerVersion;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.MinorLinkerVersion"]/*'/>
    public byte MinorLinkerVersion;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.SizeOfCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfCode;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.SizeOfInitializedData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfInitializedData;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.SizeOfUninitializedData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfUninitializedData;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.AddressOfEntryPoint"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AddressOfEntryPoint;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.BaseOfCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BaseOfCode;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.ImageBase"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong ImageBase;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.SectionAlignment"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SectionAlignment;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.FileAlignment"]/*'/>
    [NativeTypeName("DWORD")]
    public uint FileAlignment;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.MajorOperatingSystemVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MajorOperatingSystemVersion;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.MinorOperatingSystemVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MinorOperatingSystemVersion;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.MajorImageVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MajorImageVersion;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.MinorImageVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MinorImageVersion;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.MajorSubsystemVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MajorSubsystemVersion;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.MinorSubsystemVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MinorSubsystemVersion;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.Win32VersionValue"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Win32VersionValue;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.SizeOfImage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfImage;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.SizeOfHeaders"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfHeaders;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.CheckSum"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CheckSum;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.Subsystem"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Subsystem;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.DllCharacteristics"]/*'/>
    [NativeTypeName("WORD")]
    public ushort DllCharacteristics;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.SizeOfStackReserve"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong SizeOfStackReserve;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.SizeOfStackCommit"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong SizeOfStackCommit;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.SizeOfHeapReserve"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong SizeOfHeapReserve;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.SizeOfHeapCommit"]/*'/>
    [NativeTypeName("ULONGLONG")]
    public ulong SizeOfHeapCommit;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.LoaderFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LoaderFlags;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.NumberOfRvaAndSizes"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfRvaAndSizes;
    /// <include file='IMAGE_OPTIONAL_HEADER64.xml' path='doc/member[@name="IMAGE_OPTIONAL_HEADER64.DataDirectory"]/*'/>
    [NativeTypeName("IMAGE_DATA_DIRECTORY[16]")]
    public _DataDirectory_e__FixedBuffer DataDirectory;
    /// <include file='_DataDirectory_e__FixedBuffer.xml' path='doc/member[@name="_DataDirectory_e__FixedBuffer"]/*'/>
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _DataDirectory_e__FixedBuffer
    {
        public IMAGE_DATA_DIRECTORY e0;
        public IMAGE_DATA_DIRECTORY e1;
        public IMAGE_DATA_DIRECTORY e2;
        public IMAGE_DATA_DIRECTORY e3;
        public IMAGE_DATA_DIRECTORY e4;
        public IMAGE_DATA_DIRECTORY e5;
        public IMAGE_DATA_DIRECTORY e6;
        public IMAGE_DATA_DIRECTORY e7;
        public IMAGE_DATA_DIRECTORY e8;
        public IMAGE_DATA_DIRECTORY e9;
        public IMAGE_DATA_DIRECTORY e10;
        public IMAGE_DATA_DIRECTORY e11;
        public IMAGE_DATA_DIRECTORY e12;
        public IMAGE_DATA_DIRECTORY e13;
        public IMAGE_DATA_DIRECTORY e14;
        public IMAGE_DATA_DIRECTORY e15;
        [UnscopedRef]
        public ref IMAGE_DATA_DIRECTORY this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<IMAGE_DATA_DIRECTORY> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 16);
    }
}