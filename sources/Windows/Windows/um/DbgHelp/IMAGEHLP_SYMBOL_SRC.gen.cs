// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='IMAGEHLP_SYMBOL_SRC.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_SRC"]/*' />
public unsafe partial struct IMAGEHLP_SYMBOL_SRC
{
    /// <include file='IMAGEHLP_SYMBOL_SRC.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_SRC.sizeofstruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint sizeofstruct;

    /// <include file='IMAGEHLP_SYMBOL_SRC.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_SRC.type"]/*' />
    [NativeTypeName("DWORD")]
    public uint type;

    /// <include file='IMAGEHLP_SYMBOL_SRC.xml' path='doc/member[@name="IMAGEHLP_SYMBOL_SRC.file"]/*' />
    [NativeTypeName("char[260]")]
    public fixed sbyte file[260];
}
