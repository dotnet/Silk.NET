// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGE_FILE_HEADER.xml' path='doc/member[@name="IMAGE_FILE_HEADER"]/*' />
public partial struct IMAGE_FILE_HEADER
{
    /// <include file='IMAGE_FILE_HEADER.xml' path='doc/member[@name="IMAGE_FILE_HEADER.Machine"]/*' />
    [NativeTypeName("WORD")]
    public ushort Machine;

    /// <include file='IMAGE_FILE_HEADER.xml' path='doc/member[@name="IMAGE_FILE_HEADER.NumberOfSections"]/*' />
    [NativeTypeName("WORD")]
    public ushort NumberOfSections;

    /// <include file='IMAGE_FILE_HEADER.xml' path='doc/member[@name="IMAGE_FILE_HEADER.TimeDateStamp"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    /// <include file='IMAGE_FILE_HEADER.xml' path='doc/member[@name="IMAGE_FILE_HEADER.PointerToSymbolTable"]/*' />
    [NativeTypeName("DWORD")]
    public uint PointerToSymbolTable;

    /// <include file='IMAGE_FILE_HEADER.xml' path='doc/member[@name="IMAGE_FILE_HEADER.NumberOfSymbols"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfSymbols;

    /// <include file='IMAGE_FILE_HEADER.xml' path='doc/member[@name="IMAGE_FILE_HEADER.SizeOfOptionalHeader"]/*' />
    [NativeTypeName("WORD")]
    public ushort SizeOfOptionalHeader;

    /// <include file='IMAGE_FILE_HEADER.xml' path='doc/member[@name="IMAGE_FILE_HEADER.Characteristics"]/*' />
    [NativeTypeName("WORD")]
    public ushort Characteristics;
}
