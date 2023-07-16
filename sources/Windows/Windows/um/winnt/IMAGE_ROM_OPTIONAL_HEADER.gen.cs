// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER"]/*'/>
public unsafe partial struct IMAGE_ROM_OPTIONAL_HEADER
{
    /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.Magic"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Magic;
    /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.MajorLinkerVersion"]/*'/>
    public byte MajorLinkerVersion;
    /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.MinorLinkerVersion"]/*'/>
    public byte MinorLinkerVersion;
    /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.SizeOfCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfCode;
    /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.SizeOfInitializedData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfInitializedData;
    /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.SizeOfUninitializedData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfUninitializedData;
    /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.AddressOfEntryPoint"]/*'/>
    [NativeTypeName("DWORD")]
    public uint AddressOfEntryPoint;
    /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.BaseOfCode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BaseOfCode;
    /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.BaseOfData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BaseOfData;
    /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.BaseOfBss"]/*'/>
    [NativeTypeName("DWORD")]
    public uint BaseOfBss;
    /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.GprMask"]/*'/>
    [NativeTypeName("DWORD")]
    public uint GprMask;
    /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.CprMask"]/*'/>
    [NativeTypeName("DWORD[4]")]
    public fixed uint CprMask[4];
    /// <include file='IMAGE_ROM_OPTIONAL_HEADER.xml' path='doc/member[@name="IMAGE_ROM_OPTIONAL_HEADER.GpValue"]/*'/>
    [NativeTypeName("DWORD")]
    public uint GpValue;
}