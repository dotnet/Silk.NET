// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='CLIENTCREATESTRUCT.xml' path='doc/member[@name="CLIENTCREATESTRUCT"]/*' />
public partial struct CLIENTCREATESTRUCT
{
    /// <include file='CLIENTCREATESTRUCT.xml' path='doc/member[@name="CLIENTCREATESTRUCT.hWindowMenu"]/*' />
    public HANDLE hWindowMenu;

    /// <include file='CLIENTCREATESTRUCT.xml' path='doc/member[@name="CLIENTCREATESTRUCT.idFirstChild"]/*' />
    public uint idFirstChild;
}
