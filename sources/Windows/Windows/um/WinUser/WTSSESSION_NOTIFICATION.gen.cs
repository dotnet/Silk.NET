// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='WTSSESSION_NOTIFICATION.xml' path='doc/member[@name="WTSSESSION_NOTIFICATION"]/*' />
public partial struct WTSSESSION_NOTIFICATION
{
    /// <include file='WTSSESSION_NOTIFICATION.xml' path='doc/member[@name="WTSSESSION_NOTIFICATION.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='WTSSESSION_NOTIFICATION.xml' path='doc/member[@name="WTSSESSION_NOTIFICATION.dwSessionId"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSessionId;
}
