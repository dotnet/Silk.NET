// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='STICKYKEYS.xml' path='doc/member[@name="STICKYKEYS"]/*' />
public partial struct STICKYKEYS
{
    /// <include file='STICKYKEYS.xml' path='doc/member[@name="STICKYKEYS.cbSize"]/*' />
    public uint cbSize;

    /// <include file='STICKYKEYS.xml' path='doc/member[@name="STICKYKEYS.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}
