// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct LOADED_IMAGE
{
    [NativeTypeName("PSTR")]
    public sbyte* ModuleName;
    public HANDLE hFile;

    [NativeTypeName("PUCHAR")]
    public byte* MappedAddress;

    [NativeTypeName("PIMAGE_NT_HEADERS64")]
    public IMAGE_NT_HEADERS64* FileHeader;

    [NativeTypeName("PIMAGE_SECTION_HEADER")]
    public IMAGE_SECTION_HEADER* LastRvaSection;

    [NativeTypeName("ULONG")]
    public uint NumberOfSections;

    [NativeTypeName("PIMAGE_SECTION_HEADER")]
    public IMAGE_SECTION_HEADER* Sections;

    [NativeTypeName("ULONG")]
    public uint Characteristics;

    [NativeTypeName("BOOLEAN")]
    public byte fSystemImage;

    [NativeTypeName("BOOLEAN")]
    public byte fDOSImage;

    [NativeTypeName("BOOLEAN")]
    public byte fReadOnly;

    [NativeTypeName("UCHAR")]
    public byte Version;
    public LIST_ENTRY Links;

    [NativeTypeName("ULONG")]
    public uint SizeOfImage;
}
