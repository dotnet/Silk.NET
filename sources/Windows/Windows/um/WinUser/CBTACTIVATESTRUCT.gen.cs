// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CBTACTIVATESTRUCT.xml' path='doc/member[@name="CBTACTIVATESTRUCT"]/*' />
public partial struct CBTACTIVATESTRUCT
{
    /// <include file='CBTACTIVATESTRUCT.xml' path='doc/member[@name="CBTACTIVATESTRUCT.fMouse"]/*' />
    public BOOL fMouse;

    /// <include file='CBTACTIVATESTRUCT.xml' path='doc/member[@name="CBTACTIVATESTRUCT.hWndActive"]/*' />
    public HWND hWndActive;
}
