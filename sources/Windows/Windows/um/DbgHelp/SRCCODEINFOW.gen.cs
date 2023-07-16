// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SRCCODEINFOW.xml' path='doc/member[@name="SRCCODEINFOW"]/*'/>
public unsafe partial struct SRCCODEINFOW
{
    /// <include file='SRCCODEINFOW.xml' path='doc/member[@name="SRCCODEINFOW.SizeOfStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;
    /// <include file='SRCCODEINFOW.xml' path='doc/member[@name="SRCCODEINFOW.Key"]/*'/>
    [NativeTypeName("PVOID")]
    public void* Key;
    /// <include file='SRCCODEINFOW.xml' path='doc/member[@name="SRCCODEINFOW.ModBase"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong ModBase;
    /// <include file='SRCCODEINFOW.xml' path='doc/member[@name="SRCCODEINFOW.Obj"]/*'/>
    [NativeTypeName("WCHAR[261]")]
    public fixed ushort Obj[261];
    /// <include file='SRCCODEINFOW.xml' path='doc/member[@name="SRCCODEINFOW.FileName"]/*'/>
    [NativeTypeName("WCHAR[261]")]
    public fixed ushort FileName[261];
    /// <include file='SRCCODEINFOW.xml' path='doc/member[@name="SRCCODEINFOW.LineNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LineNumber;
    /// <include file='SRCCODEINFOW.xml' path='doc/member[@name="SRCCODEINFOW.Address"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong Address;
}