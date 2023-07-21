// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CONSOLE_FONT_INFOEX.xml' path='doc/member[@name="CONSOLE_FONT_INFOEX"]/*' />
public unsafe partial struct CONSOLE_FONT_INFOEX
{
    /// <include file='CONSOLE_FONT_INFOEX.xml' path='doc/member[@name="CONSOLE_FONT_INFOEX.cbSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbSize;

    /// <include file='CONSOLE_FONT_INFOEX.xml' path='doc/member[@name="CONSOLE_FONT_INFOEX.nFont"]/*' />
    [NativeTypeName("DWORD")]
    public uint nFont;

    /// <include file='CONSOLE_FONT_INFOEX.xml' path='doc/member[@name="CONSOLE_FONT_INFOEX.dwFontSize"]/*' />
    public COORD dwFontSize;

    /// <include file='CONSOLE_FONT_INFOEX.xml' path='doc/member[@name="CONSOLE_FONT_INFOEX.FontFamily"]/*' />
    public uint FontFamily;

    /// <include file='CONSOLE_FONT_INFOEX.xml' path='doc/member[@name="CONSOLE_FONT_INFOEX.FontWeight"]/*' />
    public uint FontWeight;

    /// <include file='CONSOLE_FONT_INFOEX.xml' path='doc/member[@name="CONSOLE_FONT_INFOEX.FaceName"]/*' />
    [NativeTypeName("WCHAR[32]")]
    public fixed ushort FaceName[32];
}
