// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGEHLP_LINEW.xml' path='doc/member[@name="IMAGEHLP_LINEW"]/*' />
public unsafe partial struct IMAGEHLP_LINEW
{
    /// <include file='IMAGEHLP_LINEW.xml' path='doc/member[@name="IMAGEHLP_LINEW.SizeOfStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;

    /// <include file='IMAGEHLP_LINEW.xml' path='doc/member[@name="IMAGEHLP_LINEW.Key"]/*' />
    [NativeTypeName("PVOID")]
    public void* Key;

    /// <include file='IMAGEHLP_LINEW.xml' path='doc/member[@name="IMAGEHLP_LINEW.LineNumber"]/*' />
    [NativeTypeName("DWORD")]
    public uint LineNumber;

    /// <include file='IMAGEHLP_LINEW.xml' path='doc/member[@name="IMAGEHLP_LINEW.FileName"]/*' />
    [NativeTypeName("PCHAR")]
    public sbyte* FileName;

    /// <include file='IMAGEHLP_LINEW.xml' path='doc/member[@name="IMAGEHLP_LINEW.Address"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong Address;
}
