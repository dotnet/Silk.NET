// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='PROPBAG2.xml' path='doc/member[@name="PROPBAG2"]/*'/>
public unsafe partial struct PROPBAG2
{
    /// <include file='PROPBAG2.xml' path='doc/member[@name="PROPBAG2.dwType"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwType;
    /// <include file='PROPBAG2.xml' path='doc/member[@name="PROPBAG2.vt"]/*'/>
    [NativeTypeName("VARTYPE")]
    public ushort vt;
    /// <include file='PROPBAG2.xml' path='doc/member[@name="PROPBAG2.cfType"]/*'/>
    [NativeTypeName("CLIPFORMAT")]
    public ushort cfType;
    /// <include file='PROPBAG2.xml' path='doc/member[@name="PROPBAG2.dwHint"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwHint;
    /// <include file='PROPBAG2.xml' path='doc/member[@name="PROPBAG2.pstrName"]/*'/>
    [NativeTypeName("LPOLESTR")]
    public ushort* pstrName;
    /// <include file='PROPBAG2.xml' path='doc/member[@name="PROPBAG2.clsid"]/*'/>
    [NativeTypeName("CLSID")]
    public Guid clsid;
}