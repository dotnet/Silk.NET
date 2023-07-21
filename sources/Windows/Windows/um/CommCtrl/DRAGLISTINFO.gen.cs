// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='DRAGLISTINFO.xml' path='doc/member[@name="DRAGLISTINFO"]/*' />
public partial struct DRAGLISTINFO
{
    /// <include file='DRAGLISTINFO.xml' path='doc/member[@name="DRAGLISTINFO.uNotification"]/*' />
    public uint uNotification;

    /// <include file='DRAGLISTINFO.xml' path='doc/member[@name="DRAGLISTINFO.hWnd"]/*' />
    public HWND hWnd;

    /// <include file='DRAGLISTINFO.xml' path='doc/member[@name="DRAGLISTINFO.ptCursor"]/*' />
    public POINT ptCursor;
}
