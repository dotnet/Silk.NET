// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='ANON_OBJECT_HEADER_BIGOBJ.xml' path='doc/member[@name="ANON_OBJECT_HEADER_BIGOBJ"]/*'/>
public partial struct ANON_OBJECT_HEADER_BIGOBJ
{
    /// <include file='ANON_OBJECT_HEADER_BIGOBJ.xml' path='doc/member[@name="ANON_OBJECT_HEADER_BIGOBJ.Sig1"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Sig1;
    /// <include file='ANON_OBJECT_HEADER_BIGOBJ.xml' path='doc/member[@name="ANON_OBJECT_HEADER_BIGOBJ.Sig2"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Sig2;
    /// <include file='ANON_OBJECT_HEADER_BIGOBJ.xml' path='doc/member[@name="ANON_OBJECT_HEADER_BIGOBJ.Version"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Version;
    /// <include file='ANON_OBJECT_HEADER_BIGOBJ.xml' path='doc/member[@name="ANON_OBJECT_HEADER_BIGOBJ.Machine"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Machine;
    /// <include file='ANON_OBJECT_HEADER_BIGOBJ.xml' path='doc/member[@name="ANON_OBJECT_HEADER_BIGOBJ.TimeDateStamp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;
    /// <include file='ANON_OBJECT_HEADER_BIGOBJ.xml' path='doc/member[@name="ANON_OBJECT_HEADER_BIGOBJ.ClassID"]/*'/>
    [NativeTypeName("CLSID")]
    public Guid ClassID;
    /// <include file='ANON_OBJECT_HEADER_BIGOBJ.xml' path='doc/member[@name="ANON_OBJECT_HEADER_BIGOBJ.SizeOfData"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfData;
    /// <include file='ANON_OBJECT_HEADER_BIGOBJ.xml' path='doc/member[@name="ANON_OBJECT_HEADER_BIGOBJ.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='ANON_OBJECT_HEADER_BIGOBJ.xml' path='doc/member[@name="ANON_OBJECT_HEADER_BIGOBJ.MetaDataSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MetaDataSize;
    /// <include file='ANON_OBJECT_HEADER_BIGOBJ.xml' path='doc/member[@name="ANON_OBJECT_HEADER_BIGOBJ.MetaDataOffset"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MetaDataOffset;
    /// <include file='ANON_OBJECT_HEADER_BIGOBJ.xml' path='doc/member[@name="ANON_OBJECT_HEADER_BIGOBJ.NumberOfSections"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfSections;
    /// <include file='ANON_OBJECT_HEADER_BIGOBJ.xml' path='doc/member[@name="ANON_OBJECT_HEADER_BIGOBJ.PointerToSymbolTable"]/*'/>
    [NativeTypeName("DWORD")]
    public uint PointerToSymbolTable;
    /// <include file='ANON_OBJECT_HEADER_BIGOBJ.xml' path='doc/member[@name="ANON_OBJECT_HEADER_BIGOBJ.NumberOfSymbols"]/*'/>
    [NativeTypeName("DWORD")]
    public uint NumberOfSymbols;
}