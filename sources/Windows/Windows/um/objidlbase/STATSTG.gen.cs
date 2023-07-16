// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='STATSTG.xml' path='doc/member[@name="STATSTG"]/*'/>
public unsafe partial struct STATSTG
{
    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.pwcsName"]/*'/>
    [NativeTypeName("LPOLESTR")]
    public ushort* pwcsName;
    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.type"]/*'/>
    [NativeTypeName("DWORD")]
    public uint type;
    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.cbSize"]/*'/>
    public ULARGE_INTEGER cbSize;
    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.mtime"]/*'/>
    public FILETIME mtime;
    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.ctime"]/*'/>
    public FILETIME ctime;
    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.atime"]/*'/>
    public FILETIME atime;
    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.grfMode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint grfMode;
    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.grfLocksSupported"]/*'/>
    [NativeTypeName("DWORD")]
    public uint grfLocksSupported;
    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.clsid"]/*'/>
    [NativeTypeName("CLSID")]
    public Guid clsid;
    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.grfStateBits"]/*'/>
    [NativeTypeName("DWORD")]
    public uint grfStateBits;
    /// <include file='STATSTG.xml' path='doc/member[@name="STATSTG.reserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint reserved;
}