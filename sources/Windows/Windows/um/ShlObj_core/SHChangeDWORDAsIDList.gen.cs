// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='SHChangeDWORDAsIDList.xml' path='doc/member[@name="SHChangeDWORDAsIDList"]/*'/>
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct SHChangeDWORDAsIDList
{
    /// <include file='SHChangeDWORDAsIDList.xml' path='doc/member[@name="SHChangeDWORDAsIDList.cb"]/*'/>
    public ushort cb;
    /// <include file='SHChangeDWORDAsIDList.xml' path='doc/member[@name="SHChangeDWORDAsIDList.dwItem1"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwItem1;
    /// <include file='SHChangeDWORDAsIDList.xml' path='doc/member[@name="SHChangeDWORDAsIDList.dwItem2"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwItem2;
    /// <include file='SHChangeDWORDAsIDList.xml' path='doc/member[@name="SHChangeDWORDAsIDList.cbZero"]/*'/>
    public ushort cbZero;
}