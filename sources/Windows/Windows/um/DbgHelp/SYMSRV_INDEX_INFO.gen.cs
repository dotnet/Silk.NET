// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='SYMSRV_INDEX_INFO.xml' path='doc/member[@name="SYMSRV_INDEX_INFO"]/*'/>
public unsafe partial struct SYMSRV_INDEX_INFO
{
    /// <include file='SYMSRV_INDEX_INFO.xml' path='doc/member[@name="SYMSRV_INDEX_INFO.sizeofstruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint sizeofstruct;
    /// <include file='SYMSRV_INDEX_INFO.xml' path='doc/member[@name="SYMSRV_INDEX_INFO.file"]/*'/>
    [NativeTypeName("char[261]")]
    public fixed sbyte file[261];
    /// <include file='SYMSRV_INDEX_INFO.xml' path='doc/member[@name="SYMSRV_INDEX_INFO.stripped"]/*'/>
    public BOOL stripped;
    /// <include file='SYMSRV_INDEX_INFO.xml' path='doc/member[@name="SYMSRV_INDEX_INFO.timestamp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint timestamp;
    /// <include file='SYMSRV_INDEX_INFO.xml' path='doc/member[@name="SYMSRV_INDEX_INFO.size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint size;
    /// <include file='SYMSRV_INDEX_INFO.xml' path='doc/member[@name="SYMSRV_INDEX_INFO.dbgfile"]/*'/>
    [NativeTypeName("char[261]")]
    public fixed sbyte dbgfile[261];
    /// <include file='SYMSRV_INDEX_INFO.xml' path='doc/member[@name="SYMSRV_INDEX_INFO.pdbfile"]/*'/>
    [NativeTypeName("char[261]")]
    public fixed sbyte pdbfile[261];
    /// <include file='SYMSRV_INDEX_INFO.xml' path='doc/member[@name="SYMSRV_INDEX_INFO.guid"]/*'/>
    public Guid guid;
    /// <include file='SYMSRV_INDEX_INFO.xml' path='doc/member[@name="SYMSRV_INDEX_INFO.sig"]/*'/>
    [NativeTypeName("DWORD")]
    public uint sig;
    /// <include file='SYMSRV_INDEX_INFO.xml' path='doc/member[@name="SYMSRV_INDEX_INFO.age"]/*'/>
    [NativeTypeName("DWORD")]
    public uint age;
}