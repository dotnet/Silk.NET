// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO"]/*' />
public unsafe partial struct SYMBOL_INFO
{
    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.SizeOfStruct"]/*' />
    [NativeTypeName("ULONG")]
    public uint SizeOfStruct;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.TypeIndex"]/*' />
    [NativeTypeName("ULONG")]
    public uint TypeIndex;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Reserved"]/*' />
    [NativeTypeName("ULONG64[2]")]
    public fixed ulong Reserved[2];

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Index"]/*' />
    [NativeTypeName("ULONG")]
    public uint Index;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Size"]/*' />
    [NativeTypeName("ULONG")]
    public uint Size;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.ModBase"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong ModBase;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Flags"]/*' />
    [NativeTypeName("ULONG")]
    public uint Flags;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Value"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong Value;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Address"]/*' />
    [NativeTypeName("ULONG64")]
    public ulong Address;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Register"]/*' />
    [NativeTypeName("ULONG")]
    public uint Register;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Scope"]/*' />
    [NativeTypeName("ULONG")]
    public uint Scope;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Tag"]/*' />
    [NativeTypeName("ULONG")]
    public uint Tag;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.NameLen"]/*' />
    [NativeTypeName("ULONG")]
    public uint NameLen;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.MaxNameLen"]/*' />
    [NativeTypeName("ULONG")]
    public uint MaxNameLen;

    /// <include file='SYMBOL_INFO.xml' path='doc/member[@name="SYMBOL_INFO.Name"]/*' />
    [NativeTypeName("CHAR[1]")]
    public fixed sbyte Name[1];
}
