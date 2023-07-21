// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="CRITICAL_SECTION_DEBUG"]/*' />
public unsafe partial struct CRITICAL_SECTION_DEBUG
{
    /// <include file='CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="CRITICAL_SECTION_DEBUG.Type"]/*' />
    [NativeTypeName("WORD")]
    public ushort Type;

    /// <include file='CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="CRITICAL_SECTION_DEBUG.CreatorBackTraceIndex"]/*' />
    [NativeTypeName("WORD")]
    public ushort CreatorBackTraceIndex;

    /// <include file='CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="CRITICAL_SECTION_DEBUG.CriticalSection"]/*' />
    [NativeTypeName("struct _RTL_CRITICAL_SECTION *")]
    public CRITICAL_SECTION* CriticalSection;

    /// <include file='CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="CRITICAL_SECTION_DEBUG.ProcessLocksList"]/*' />
    public LIST_ENTRY ProcessLocksList;

    /// <include file='CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="CRITICAL_SECTION_DEBUG.EntryCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint EntryCount;

    /// <include file='CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="CRITICAL_SECTION_DEBUG.ContentionCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint ContentionCount;

    /// <include file='CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="CRITICAL_SECTION_DEBUG.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="CRITICAL_SECTION_DEBUG.CreatorBackTraceIndexHigh"]/*' />
    [NativeTypeName("WORD")]
    public ushort CreatorBackTraceIndexHigh;

    /// <include file='CRITICAL_SECTION_DEBUG.xml' path='doc/member[@name="CRITICAL_SECTION_DEBUG.Identifier"]/*' />
    [NativeTypeName("WORD")]
    public ushort Identifier;
}
