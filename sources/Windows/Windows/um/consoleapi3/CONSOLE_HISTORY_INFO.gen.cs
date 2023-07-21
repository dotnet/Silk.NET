// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/consoleapi3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CONSOLE_HISTORY_INFO.xml' path='doc/member[@name="CONSOLE_HISTORY_INFO"]/*' />
public partial struct CONSOLE_HISTORY_INFO
{
    /// <include file='CONSOLE_HISTORY_INFO.xml' path='doc/member[@name="CONSOLE_HISTORY_INFO.cbSize"]/*' />
    public uint cbSize;

    /// <include file='CONSOLE_HISTORY_INFO.xml' path='doc/member[@name="CONSOLE_HISTORY_INFO.HistoryBufferSize"]/*' />
    public uint HistoryBufferSize;

    /// <include file='CONSOLE_HISTORY_INFO.xml' path='doc/member[@name="CONSOLE_HISTORY_INFO.NumberOfHistoryBuffers"]/*' />
    public uint NumberOfHistoryBuffers;

    /// <include file='CONSOLE_HISTORY_INFO.xml' path='doc/member[@name="CONSOLE_HISTORY_INFO.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}
