// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600"]/*'/>
public unsafe partial struct ACTCTX_SECTION_KEYED_DATA_2600
{
    /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.cbSize"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbSize;
    /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.ulDataFormatVersion"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulDataFormatVersion;
    /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.lpData"]/*'/>
    [NativeTypeName("PVOID")]
    public void* lpData;
    /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.ulLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulLength;
    /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.lpSectionGlobalData"]/*'/>
    [NativeTypeName("PVOID")]
    public void* lpSectionGlobalData;
    /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.ulSectionGlobalDataLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulSectionGlobalDataLength;
    /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.lpSectionBase"]/*'/>
    [NativeTypeName("PVOID")]
    public void* lpSectionBase;
    /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.ulSectionTotalLength"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulSectionTotalLength;
    /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.hActCtx"]/*'/>
    public HANDLE hActCtx;
    /// <include file='ACTCTX_SECTION_KEYED_DATA_2600.xml' path='doc/member[@name="ACTCTX_SECTION_KEYED_DATA_2600.ulAssemblyRosterIndex"]/*'/>
    [NativeTypeName("ULONG")]
    public uint ulAssemblyRosterIndex;
}