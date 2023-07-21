// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGEHLP_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_SYMBOL"]/*' />
public unsafe partial struct IMAGEHLP_SYMBOL
{
    /// <include file='IMAGEHLP_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_SYMBOL.SizeOfStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;

    /// <include file='IMAGEHLP_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_SYMBOL.Address"]/*' />
    [NativeTypeName("DWORD")]
    public uint Address;

    /// <include file='IMAGEHLP_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_SYMBOL.Size"]/*' />
    [NativeTypeName("DWORD")]
    public uint Size;

    /// <include file='IMAGEHLP_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_SYMBOL.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;

    /// <include file='IMAGEHLP_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_SYMBOL.MaxNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint MaxNameLength;

    /// <include file='IMAGEHLP_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_SYMBOL.Name"]/*' />
    [NativeTypeName("CHAR[1]")]
    public fixed sbyte Name[1];
}
