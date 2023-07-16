// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER"]/*'/>
public unsafe partial struct IMAGE_SEPARATE_DEBUG_HEADER
{
    /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.Signature"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Signature;
    /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.Flags"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Flags;
    /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.Machine"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Machine;
    /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.Characteristics"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Characteristics;
    /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.TimeDateStamp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;
    /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.CheckSum"]/*'/>
    [NativeTypeName("DWORD")]
    public uint CheckSum;
    /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.ImageBase"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ImageBase;
    /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.SizeOfImage"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfImage;
    /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.NumberOfSections"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfSections;
    /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.ExportedNamesSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ExportedNamesSize;
    /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.DebugDirectorySize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DebugDirectorySize;
    /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.SectionAlignment"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SectionAlignment;
    /// <include file='IMAGE_SEPARATE_DEBUG_HEADER.xml' path='doc/member[@name="IMAGE_SEPARATE_DEBUG_HEADER.Reserved"]/*'/>
    [NativeTypeName("DWORD[2]")]
    public fixed uint Reserved[2];
}