// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imm.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CANDIDATELIST.xml' path='doc/member[@name="CANDIDATELIST"]/*'/>
public unsafe partial struct CANDIDATELIST
{
    /// <include file='CANDIDATELIST.xml' path='doc/member[@name="CANDIDATELIST.dwSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSize;
    /// <include file='CANDIDATELIST.xml' path='doc/member[@name="CANDIDATELIST.dwStyle"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwStyle;
    /// <include file='CANDIDATELIST.xml' path='doc/member[@name="CANDIDATELIST.dwCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwCount;
    /// <include file='CANDIDATELIST.xml' path='doc/member[@name="CANDIDATELIST.dwSelection"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwSelection;
    /// <include file='CANDIDATELIST.xml' path='doc/member[@name="CANDIDATELIST.dwPageStart"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPageStart;
    /// <include file='CANDIDATELIST.xml' path='doc/member[@name="CANDIDATELIST.dwPageSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwPageSize;
    /// <include file='CANDIDATELIST.xml' path='doc/member[@name="CANDIDATELIST.dwOffset"]/*'/>
    [NativeTypeName("DWORD[1]")]
    public fixed uint dwOffset[1];
}