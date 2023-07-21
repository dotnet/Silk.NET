// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGEHLP_SYMBOLW.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW"]/*' />
public unsafe partial struct IMAGEHLP_SYMBOLW
{
    /// <include file='IMAGEHLP_SYMBOLW.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW.SizeOfStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;

    /// <include file='IMAGEHLP_SYMBOLW.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW.Address"]/*' />
    [NativeTypeName("DWORD")]
    public uint Address;

    /// <include file='IMAGEHLP_SYMBOLW.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='IMAGEHLP_SYMBOLW.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='IMAGEHLP_SYMBOLW.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW.MaxNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxNameLength;

    /// <include file='IMAGEHLP_SYMBOLW.xml' path='doc/member[@name="IMAGEHLP_SYMBOLW.Name"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public fixed ushort Name[1];
}
