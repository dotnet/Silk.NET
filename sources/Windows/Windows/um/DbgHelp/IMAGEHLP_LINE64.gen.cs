// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAGEHLP_LINE64.xml' path='doc/member[@name="IMAGEHLP_LINE64"]/*'/>
public unsafe partial struct IMAGEHLP_LINE64
{
    /// <include file='IMAGEHLP_LINE64.xml' path='doc/member[@name="IMAGEHLP_LINE64.SizeOfStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;
    /// <include file='IMAGEHLP_LINE64.xml' path='doc/member[@name="IMAGEHLP_LINE64.Key"]/*'/>
    [NativeTypeName("PVOID")]
    public void* Key;
    /// <include file='IMAGEHLP_LINE64.xml' path='doc/member[@name="IMAGEHLP_LINE64.LineNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LineNumber;
    /// <include file='IMAGEHLP_LINE64.xml' path='doc/member[@name="IMAGEHLP_LINE64.FileName"]/*'/>
    [NativeTypeName("PCHAR")]
    public sbyte* FileName;
    /// <include file='IMAGEHLP_LINE64.xml' path='doc/member[@name="IMAGEHLP_LINE64.Address"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong Address;
}