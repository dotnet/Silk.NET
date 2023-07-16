// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LOADED_IMAGE.xml' path='doc/member[@name="LOADED_IMAGE"]/*'/>
public unsafe partial struct LOADED_IMAGE
{
    /// <include file='LOADED_IMAGE.xml' path='doc/member[@name="LOADED_IMAGE.ModuleName"]/*'/>
    [NativeTypeName("PSTR")]
    public sbyte* ModuleName;
    /// <include file='LOADED_IMAGE.xml' path='doc/member[@name="LOADED_IMAGE.hFile"]/*'/>
    public HANDLE hFile;
    /// <include file='LOADED_IMAGE.xml' path='doc/member[@name="LOADED_IMAGE.MappedAddress"]/*'/>
    [NativeTypeName("PUCHAR")]
    public byte* MappedAddress;
    /// <include file='LOADED_IMAGE.xml' path='doc/member[@name="LOADED_IMAGE.FileHeader"]/*'/>
    [NativeTypeName("PIMAGE_NT_HEADERS64")]
    public IMAGE_NT_HEADERS64* FileHeader;
    /// <include file='LOADED_IMAGE.xml' path='doc/member[@name="LOADED_IMAGE.LastRvaSection"]/*'/>
    [NativeTypeName("PIMAGE_SECTION_HEADER")]
    public IMAGE_SECTION_HEADER* LastRvaSection;
    /// <include file='LOADED_IMAGE.xml' path='doc/member[@name="LOADED_IMAGE.NumberOfSections"]/*'/>
    [NativeTypeName("ULONG")]
    public uint NumberOfSections;
    /// <include file='LOADED_IMAGE.xml' path='doc/member[@name="LOADED_IMAGE.Sections"]/*'/>
    [NativeTypeName("PIMAGE_SECTION_HEADER")]
    public IMAGE_SECTION_HEADER* Sections;
    /// <include file='LOADED_IMAGE.xml' path='doc/member[@name="LOADED_IMAGE.Characteristics"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Characteristics;
    /// <include file='LOADED_IMAGE.xml' path='doc/member[@name="LOADED_IMAGE.fSystemImage"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte fSystemImage;
    /// <include file='LOADED_IMAGE.xml' path='doc/member[@name="LOADED_IMAGE.fDOSImage"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte fDOSImage;
    /// <include file='LOADED_IMAGE.xml' path='doc/member[@name="LOADED_IMAGE.fReadOnly"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte fReadOnly;
    /// <include file='LOADED_IMAGE.xml' path='doc/member[@name="LOADED_IMAGE.Version"]/*'/>
    [NativeTypeName("UCHAR")]
    public byte Version;
    /// <include file='LOADED_IMAGE.xml' path='doc/member[@name="LOADED_IMAGE.Links"]/*'/>
    public LIST_ENTRY Links;
    /// <include file='LOADED_IMAGE.xml' path='doc/member[@name="LOADED_IMAGE.SizeOfImage"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SizeOfImage;
}