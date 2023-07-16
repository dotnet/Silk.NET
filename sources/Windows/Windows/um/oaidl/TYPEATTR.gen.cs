// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace Silk.NET.Windows;
/// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR"]/*'/>
public unsafe partial struct TYPEATTR
{
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.guid"]/*'/>
    public Guid guid;
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.lcid"]/*'/>
    [NativeTypeName("LCID")]
    public uint lcid;
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.dwReserved"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwReserved;
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.memidConstructor"]/*'/>
    [NativeTypeName("MEMBERID")]
    public int memidConstructor;
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.memidDestructor"]/*'/>
    [NativeTypeName("MEMBERID")]
    public int memidDestructor;
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.lpstrSchema"]/*'/>
    [NativeTypeName("LPOLESTR")]
    public ushort* lpstrSchema;
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.cbSizeInstance"]/*'/>
    [NativeTypeName("ULONG")]
    public uint cbSizeInstance;
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.typekind"]/*'/>
    public TYPEKIND typekind;
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.cFuncs"]/*'/>
    [NativeTypeName("WORD")]
    public ushort cFuncs;
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.cVars"]/*'/>
    [NativeTypeName("WORD")]
    public ushort cVars;
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.cImplTypes"]/*'/>
    [NativeTypeName("WORD")]
    public ushort cImplTypes;
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.cbSizeVft"]/*'/>
    [NativeTypeName("WORD")]
    public ushort cbSizeVft;
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.cbAlignment"]/*'/>
    [NativeTypeName("WORD")]
    public ushort cbAlignment;
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.wTypeFlags"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wTypeFlags;
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.wMajorVerNum"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wMajorVerNum;
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.wMinorVerNum"]/*'/>
    [NativeTypeName("WORD")]
    public ushort wMinorVerNum;
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.tdescAlias"]/*'/>
    public TYPEDESC tdescAlias;
    /// <include file='TYPEATTR.xml' path='doc/member[@name="TYPEATTR.idldescType"]/*'/>
    public IDLDESC idldescType;
}