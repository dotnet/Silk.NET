// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SYMBOL_INFOW.xml' path='doc/member[@name="SYMBOL_INFOW"]/*'/>
public unsafe partial struct SYMBOL_INFOW
{
    /// <include file='SYMBOL_INFOW.xml' path='doc/member[@name="SYMBOL_INFOW.SizeOfStruct"]/*'/>
    [NativeTypeName("ULONG")]
    public uint SizeOfStruct;
    /// <include file='SYMBOL_INFOW.xml' path='doc/member[@name="SYMBOL_INFOW.TypeIndex"]/*'/>
    [NativeTypeName("ULONG")]
    public uint TypeIndex;
    /// <include file='SYMBOL_INFOW.xml' path='doc/member[@name="SYMBOL_INFOW.Reserved"]/*'/>
    [NativeTypeName("ULONG64[2]")]
    public fixed ulong Reserved[2];
    /// <include file='SYMBOL_INFOW.xml' path='doc/member[@name="SYMBOL_INFOW.Index"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Index;
    /// <include file='SYMBOL_INFOW.xml' path='doc/member[@name="SYMBOL_INFOW.Size"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Size;
    /// <include file='SYMBOL_INFOW.xml' path='doc/member[@name="SYMBOL_INFOW.ModBase"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong ModBase;
    /// <include file='SYMBOL_INFOW.xml' path='doc/member[@name="SYMBOL_INFOW.Flags"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Flags;
    /// <include file='SYMBOL_INFOW.xml' path='doc/member[@name="SYMBOL_INFOW.Value"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong Value;
    /// <include file='SYMBOL_INFOW.xml' path='doc/member[@name="SYMBOL_INFOW.Address"]/*'/>
    [NativeTypeName("ULONG64")]
    public ulong Address;
    /// <include file='SYMBOL_INFOW.xml' path='doc/member[@name="SYMBOL_INFOW.Register"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Register;
    /// <include file='SYMBOL_INFOW.xml' path='doc/member[@name="SYMBOL_INFOW.Scope"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Scope;
    /// <include file='SYMBOL_INFOW.xml' path='doc/member[@name="SYMBOL_INFOW.Tag"]/*'/>
    [NativeTypeName("ULONG")]
    public uint Tag;
    /// <include file='SYMBOL_INFOW.xml' path='doc/member[@name="SYMBOL_INFOW.NameLen"]/*'/>
    [NativeTypeName("ULONG")]
    public uint NameLen;
    /// <include file='SYMBOL_INFOW.xml' path='doc/member[@name="SYMBOL_INFOW.MaxNameLen"]/*'/>
    [NativeTypeName("ULONG")]
    public uint MaxNameLen;
    /// <include file='SYMBOL_INFOW.xml' path='doc/member[@name="SYMBOL_INFOW.Name"]/*'/>
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort Name[1];
}