// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER"]/*'/>
public partial struct IMAGE_COFF_SYMBOLS_HEADER
{
    /// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER.NumberOfSymbols"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfSymbols;
    /// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER.LvaToFirstSymbol"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LvaToFirstSymbol;
    /// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER.NumberOfLinenumbers"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfLinenumbers;
    /// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER.LvaToFirstLinenumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LvaToFirstLinenumber;
    /// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER.RvaToFirstByteOfCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RvaToFirstByteOfCode;
    /// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER.RvaToLastByteOfCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RvaToLastByteOfCode;
    /// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER.RvaToFirstByteOfData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RvaToFirstByteOfData;
    /// <include file='IMAGE_COFF_SYMBOLS_HEADER.xml' path='doc/member[@name="IMAGE_COFF_SYMBOLS_HEADER.RvaToLastByteOfData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint RvaToLastByteOfData;
}