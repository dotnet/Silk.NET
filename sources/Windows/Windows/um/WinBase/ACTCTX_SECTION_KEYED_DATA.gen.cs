// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='ACTCTX_SECTION_KEYED_DATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA"]/*' />
public unsafe partial struct ACTCTX_SECTION_KEYED_DATA
{
    /// <include file='ACTCTX_SECTION_KEYED_DATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA.cbSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbSize;

    /// <include file='ACTCTX_SECTION_KEYED_DATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA.ulDataFormatVersion"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulDataFormatVersion;

    /// <include file='ACTCTX_SECTION_KEYED_DATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA.lpData"]/*' />
    [NativeTypeName("PVOID")]
    public void* lpData;

    /// <include file='ACTCTX_SECTION_KEYED_DATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA.ulLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulLength;

    /// <include file='ACTCTX_SECTION_KEYED_DATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA.lpSectionGlobalData"]/*' />
    [NativeTypeName("PVOID")]
    public void* lpSectionGlobalData;

    /// <include file='ACTCTX_SECTION_KEYED_DATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA.ulSectionGlobalDataLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulSectionGlobalDataLength;

    /// <include file='ACTCTX_SECTION_KEYED_DATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA.lpSectionBase"]/*' />
    [NativeTypeName("PVOID")]
    public void* lpSectionBase;

    /// <include file='ACTCTX_SECTION_KEYED_DATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA.ulSectionTotalLength"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulSectionTotalLength;

    /// <include file='ACTCTX_SECTION_KEYED_DATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA.hActCtx"]/*' />
    public HANDLE hActCtx;

    /// <include file='ACTCTX_SECTION_KEYED_DATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA.ulAssemblyRosterIndex"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulAssemblyRosterIndex;

    /// <include file='ACTCTX_SECTION_KEYED_DATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA.ulFlags"]/*' />
    [NativeTypeName("ULONG")]
    public uint ulFlags;

    /// <include file='ACTCTX_SECTION_KEYED_DATA.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA.AssemblyMetadata"]/*' />
    public ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA AssemblyMetadata;
}
