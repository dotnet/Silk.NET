// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAGEHLP_SYMBOLW64.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW64"]/*'/>
public unsafe partial struct IMAGEHLP_SYMBOLW64
{
    /// <include file='IMAGEHLP_SYMBOLW64.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW64.SizeOfStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;
    /// <include file='IMAGEHLP_SYMBOLW64.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW64.Address"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong Address;
    /// <include file='IMAGEHLP_SYMBOLW64.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW64.Size"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Size;
    /// <include file='IMAGEHLP_SYMBOLW64.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW64.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='IMAGEHLP_SYMBOLW64.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW64.MaxNameLength"]/*'/>
    [NativeTypeName("DWORD")]
    public uint MaxNameLength;
    /// <include file='IMAGEHLP_SYMBOLW64.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW64.Name"]/*'/>
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort Name[1];
}