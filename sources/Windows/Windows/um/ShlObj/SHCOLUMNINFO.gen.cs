// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SHCOLUMNINFO.xml' path='doc/member[@name="SHCOLUMNINFO"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public unsafe partial struct SHCOLUMNINFO
{
    /// <include file='SHCOLUMNINFO.xml' path='doc/member[@name="SHCOLUMNINFO.scid"]/*'/>
    [NativeTypeName("SHCOLUMNID")]
    public PROPERTYKEY scid;
    /// <include file='SHCOLUMNINFO.xml' path='doc/member[@name="SHCOLUMNINFO.vt"]/*'/>
    [NativeTypeName("VARTYPE")]
    public ushort vt;
    /// <include file='SHCOLUMNINFO.xml' path='doc/member[@name="SHCOLUMNINFO.fmt"]/*'/>
    [NativeTypeName("DWORD")]
    public uint fmt;
    /// <include file='SHCOLUMNINFO.xml' path='doc/member[@name="SHCOLUMNINFO.cChars"]/*'/>
    public uint cChars;
    /// <include file='SHCOLUMNINFO.xml' path='doc/member[@name="SHCOLUMNINFO.csFlags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint csFlags;
    /// <include file='SHCOLUMNINFO.xml' path='doc/member[@name="SHCOLUMNINFO.wszTitle"]/*'/>
    [NativeTypeName("WCHAR[80]")]
    public fixed ushort wszTitle[80];
    /// <include file='SHCOLUMNINFO.xml' path='doc/member[@name="SHCOLUMNINFO.wszDescription"]/*'/>
    [NativeTypeName("WCHAR[128]")]
    public fixed ushort wszDescription[128];
}