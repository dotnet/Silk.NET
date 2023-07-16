// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='IMAGEHLP_JIT_SYMBOLMAP.xml' path='doc/member[@name="IMAGEHLP_JIT_SYMBOLMAP"]/*'/>
public partial struct IMAGEHLP_JIT_SYMBOLMAP
{
    /// <include file='IMAGEHLP_JIT_SYMBOLMAP.xml' path='doc/member[@name="IMAGEHLP_JIT_SYMBOLMAP.SizeOfStruct"]/*'/>
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;
    /// <include file='IMAGEHLP_JIT_SYMBOLMAP.xml' path='doc/member[@name="IMAGEHLP_JIT_SYMBOLMAP.Address"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong Address;
    /// <include file='IMAGEHLP_JIT_SYMBOLMAP.xml' path='doc/member[@name="IMAGEHLP_JIT_SYMBOLMAP.BaseOfImage"]/*'/>
    [NativeTypeName("DWORD64")]
    public ulong BaseOfImage;
}