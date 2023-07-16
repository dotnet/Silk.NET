// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincontypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='CONSOLE_FONT_INFO.xml' path='doc/member[@name="CONSOLE_FONT_INFO"]/*'/>
public partial struct CONSOLE_FONT_INFO
{
    /// <include file='CONSOLE_FONT_INFO.xml' path='doc/member[@name="CONSOLE_FONT_INFO.nFont"]/*'/>
    [NativeTypeName("DWORD")]
    public uint nFont;
    /// <include file='CONSOLE_FONT_INFO.xml' path='doc/member[@name="CONSOLE_FONT_INFO.dwFontSize"]/*'/>
    public COORD dwFontSize;
}