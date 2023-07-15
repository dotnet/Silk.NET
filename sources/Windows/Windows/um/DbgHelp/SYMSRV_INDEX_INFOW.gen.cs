// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='SYMSRV_INDEX_INFOW.xml' path='doc/member[@name="SYMSRV_INDEX_INFOW"]/*'/>
public unsafe partial struct SYMSRV_INDEX_INFOW
{
    /// <include file='SYMSRV_INDEX_INFOW.xml' path='doc/member[@name="SYMSRV_INDEX_INFOW.sizeofstruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint sizeofstruct;
    /// <include file='SYMSRV_INDEX_INFOW.xml' path='doc/member[@name="SYMSRV_INDEX_INFOW.file"]/*'/>
    [NativeTypeName("WCHAR[261]")]
    public fixed ushort file[261];
    /// <include file='SYMSRV_INDEX_INFOW.xml' path='doc/member[@name="SYMSRV_INDEX_INFOW.stripped"]/*'/>
    public BOOL stripped;
    /// <include file='SYMSRV_INDEX_INFOW.xml' path='doc/member[@name="SYMSRV_INDEX_INFOW.timestamp"]/*'/>
    [NativeTypeName("DWORD")]
    public uint timestamp;
    /// <include file='SYMSRV_INDEX_INFOW.xml' path='doc/member[@name="SYMSRV_INDEX_INFOW.size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint size;
    /// <include file='SYMSRV_INDEX_INFOW.xml' path='doc/member[@name="SYMSRV_INDEX_INFOW.dbgfile"]/*'/>
    [NativeTypeName("WCHAR[261]")]
    public fixed ushort dbgfile[261];
    /// <include file='SYMSRV_INDEX_INFOW.xml' path='doc/member[@name="SYMSRV_INDEX_INFOW.pdbfile"]/*'/>
    [NativeTypeName("WCHAR[261]")]
    public fixed ushort pdbfile[261];
    /// <include file='SYMSRV_INDEX_INFOW.xml' path='doc/member[@name="SYMSRV_INDEX_INFOW.guid"]/*'/>
    public Guid guid;
    /// <include file='SYMSRV_INDEX_INFOW.xml' path='doc/member[@name="SYMSRV_INDEX_INFOW.sig"]/*'/>
    [NativeTypeName("DWORD")]
    public uint sig;
    /// <include file='SYMSRV_INDEX_INFOW.xml' path='doc/member[@name="SYMSRV_INDEX_INFOW.age"]/*'/>
    [NativeTypeName("DWORD")]
    public uint age;
}