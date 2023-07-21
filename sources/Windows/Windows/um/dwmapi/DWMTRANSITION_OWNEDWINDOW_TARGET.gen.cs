// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwmapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace Silk.NET.Windows;

/// <include file='DWMTRANSITION_OWNEDWINDOW_TARGET.xml' path='doc/member[@name="DWMTRANSITION_OWNEDWINDOW_TARGET"]/*' />
[SupportedOSPlatform("windows6.2")]
public enum DWMTRANSITION_OWNEDWINDOW_TARGET
{
    /// <include file='DWMTRANSITION_OWNEDWINDOW_TARGET.xml' path='doc/member[@name="DWMTRANSITION_OWNEDWINDOW_TARGET.DWMTRANSITION_OWNEDWINDOW_NULL"]/*' />
    DWMTRANSITION_OWNEDWINDOW_NULL = -1,

    /// <include file='DWMTRANSITION_OWNEDWINDOW_TARGET.xml' path='doc/member[@name="DWMTRANSITION_OWNEDWINDOW_TARGET.DWMTRANSITION_OWNEDWINDOW_REPOSITION"]/*' />
    DWMTRANSITION_OWNEDWINDOW_REPOSITION = 0,
}
