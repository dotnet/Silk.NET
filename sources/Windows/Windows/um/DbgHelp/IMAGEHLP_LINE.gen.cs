// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAGEHLP_LINE.xml' path='doc/member[@name="IMAGEHLP_LINE"]/*'/>
public unsafe partial struct IMAGEHLP_LINE
{
    /// <include file='IMAGEHLP_LINE.xml' path='doc/member[@name="IMAGEHLP_LINE.SizeOfStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;
    /// <include file='IMAGEHLP_LINE.xml' path='doc/member[@name="IMAGEHLP_LINE.Key"]/*'/>
    [NativeTypeName("PVOID")]
    public void* Key;
    /// <include file='IMAGEHLP_LINE.xml' path='doc/member[@name="IMAGEHLP_LINE.LineNumber"]/*'/>
    [NativeTypeName("DWORD")]
    public uint LineNumber;
    /// <include file='IMAGEHLP_LINE.xml' path='doc/member[@name="IMAGEHLP_LINE.FileName"]/*'/>
    [NativeTypeName("PCHAR")]
    public sbyte* FileName;
    /// <include file='IMAGEHLP_LINE.xml' path='doc/member[@name="IMAGEHLP_LINE.Address"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Address;
}