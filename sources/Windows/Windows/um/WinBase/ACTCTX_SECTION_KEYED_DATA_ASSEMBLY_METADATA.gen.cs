// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA"]/*'/>
public unsafe partial struct ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA
{
    /// <include file='ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA.lpInformation"]/*'/>
    [NativeTypeName("PVOID")]
    public void* lpInformation;
    /// <include file='ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA.lpSectionBase"]/*'/>
    [NativeTypeName("PVOID")]
    public void* lpSectionBase;
    /// <include file='ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA.ulSectionLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulSectionLength;
    /// <include file='ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA.lpSectionGlobalDataBase"]/*'/>
    [NativeTypeName("PVOID")]
    public void* lpSectionGlobalDataBase;
    /// <include file='ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA.ulSectionGlobalDataLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulSectionGlobalDataLength;
}