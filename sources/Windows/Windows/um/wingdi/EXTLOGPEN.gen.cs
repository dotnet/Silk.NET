// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN"]/*' />
public unsafe partial struct EXTLOGPEN
{
    /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpPenStyle"]/*' />
    [NativeTypeName("DWORD")]
    public uint elpPenStyle;

    /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpWidth"]/*' />
    [NativeTypeName("DWORD")]
    public uint elpWidth;

    /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpBrushStyle"]/*' />
    public uint elpBrushStyle;

    /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpColor"]/*' />
    public COLORREF elpColor;

    /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpHatch"]/*' />
    [NativeTypeName("ULONG_PTR")]
    public nuint elpHatch;

    /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpNumEntries"]/*' />
    [NativeTypeName("DWORD")]
    public uint elpNumEntries;

    /// <include file='EXTLOGPEN.xml' path='doc/member[@name="EXTLOGPEN.elpStyleEntry"]/*' />
    [NativeTypeName("DWORD[1]")]
    public fixed uint elpStyleEntry[1];
}
