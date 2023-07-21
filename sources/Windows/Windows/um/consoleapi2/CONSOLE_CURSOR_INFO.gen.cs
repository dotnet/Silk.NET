// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi2.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CONSOLE_CURSOR_INFO.xml' path='doc/member[@name="CONSOLE_CURSOR_INFO"]/*' />
public partial struct CONSOLE_CURSOR_INFO
{
    /// <include file='CONSOLE_CURSOR_INFO.xml' path='doc/member[@name="CONSOLE_CURSOR_INFO.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='CONSOLE_CURSOR_INFO.xml' path='doc/member[@name="CONSOLE_CURSOR_INFO.bVisible"]/*' />
    public BOOL bVisible;
}
