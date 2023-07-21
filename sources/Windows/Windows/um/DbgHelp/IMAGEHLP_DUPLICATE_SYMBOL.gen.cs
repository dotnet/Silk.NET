// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGEHLP_DUPLICATE_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_DUPLICATE_SYMBOL"]/*' />
public unsafe partial struct IMAGEHLP_DUPLICATE_SYMBOL
{
    /// <include file='IMAGEHLP_DUPLICATE_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_DUPLICATE_SYMBOL.SizeOfStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;

    /// <include file='IMAGEHLP_DUPLICATE_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_DUPLICATE_SYMBOL.NumberOfDups"]/*' />
    [NativeTypeName("DWORD")]
    public uint NumberOfDups;

    /// <include file='IMAGEHLP_DUPLICATE_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_DUPLICATE_SYMBOL.Symbol"]/*' />
    [NativeTypeName("PIMAGEHLP_SYMBOL")]
    public IMAGEHLP_SYMBOL* Symbol;

    /// <include file='IMAGEHLP_DUPLICATE_SYMBOL.xml' path='doc/member[@name="IMAGEHLP_DUPLICATE_SYMBOL.SelectedSymbol"]/*' />
    [NativeTypeName("DWORD")]
    public uint SelectedSymbol;
}
